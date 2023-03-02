﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Lesson83
    {
        // Các toán tử join
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            // danh sách sinh viên
            var students = new List<Student>()
            {
                new Student("B25DCCN107", "Trần Trung Đức", "Hà Nội", new float[] {3.21f, 3.29f, 3.54f}),
                new Student("B25DCCN100", "Trần Văn Đức", "Cao Bằng", new float[] {3.66f, 3.37f, 3.88f}),
                new Student("B25DCCN105", "Lê Khả Ngân", "Nam Định", new float[] {3.78f, 3.18f, 3.42f}),
                new Student("B25DCCN103", "Hoàng Thanh Mai", "Đà Nẵng", new float[] {3.54f, 3.46f, 3.74f}),
                new Student("B25DCCN109", "Nguyễn Thúy Quyên", "Hà Nội", new float[] {3.36f, 3.05f, 3.18f}),
                new Student("B25DCCN106", "Nông Tiến Mạnh", "Thái Nguyên", new float[] {3.45f, 3.51f, 3.88f}),
                new Student("B25DCCN101", "Hồ Hoài Anh", "Hà Nội", new float[] {3.69f, 3.35f, 3.68f}),
                new Student("B25DCCN104", "Trương Thanh Thức", "Hồ Chí Minh", new float[] {3.11f, 3.18f, 3.72f}),
                new Student("B25DCCN108", "Đỗ Hoàng Long", "Hồ Chí Minh", new float[] {3.88f, 3.97f, 3.49f})
            };

            // danh sách môn học
            var subjects = new List<Subject>()
            {
                new Subject{Id="SJ1001", Name="C++", Credit=3},
                new Subject{Id="SJ1002", Name="C#", Credit=3},
                new Subject{Id="SJ1003", Name="Java", Credit=4},
                new Subject{Id="SJ1004", Name="SQL", Credit=3},
                new Subject{Id="SJ1005", Name="Python", Credit=3},
                new Subject{Id="SJ1006", Name="Kotlin", Credit=4},
                new Subject{Id="SJ1007", Name="JavaScript", Credit=4},
            };

            // danh sách đăng ký
            var registers = new List<Register>()
            {
                new Register{StudentId="B25DCCN100", SubjectId="SJ1002"},
                new Register{StudentId="B25DCCN100", SubjectId="SJ1001"},
                new Register{StudentId="B25DCCN101", SubjectId="SJ1002"},
                new Register{StudentId="B25DCCN103", SubjectId="SJ1003"},
                new Register{StudentId="B25DCCN104", SubjectId="SJ1002"},
                new Register{StudentId="B25DCCN104", SubjectId="SJ1005"},
                new Register{StudentId="B25DCCN108", SubjectId="SJ1006"},
                new Register{StudentId="B25DCCN108", SubjectId="SJ1001"},
                new Register{StudentId="B25DCCN100", SubjectId="SJ1003"},
                new Register{StudentId="B25DCCN107", SubjectId="SJ1003"},
                new Register{StudentId="B25DCCN106", SubjectId="SJ1002"},
            };

            //cho biết sinh viên nào đã đăng kí môn học
            //var registedStudentQuery = (from student in students
            //                           join register in registers
            //                           on student.Id equals register.StudentId
            //                           select student).Distinct();
            //foreach (var item in registedStudentQuery)
            //{
            //    Console.WriteLine($"{item.Id} - {item.FullName}");
            //}

            //cho biết sinh viên nào đã đăng kí môn học nào
            //var registedStudentQuery = from student in students
            //                           join register in registers
            //                           on student.Id equals register.StudentId
            //                           join subject in subjects
            //                           on register.SubjectId equals subject.Id
            //                           where subject.Id == "SJ1006"
            //                           select new {student.Id , student.FullName, subject.Name, subject.Credit};
            //foreach (var item in registedStudentQuery)
            //{
            //    Console.WriteLine(item);
            //}

            //var registedStudentQuery = from student in students
            //                           join register in registers
            //                           on student.Id equals register.StudentId
            //                           join subject in subjects
            //                           on register.SubjectId equals subject.Id
            //                           orderby student.Id ascending
            //                           select new { student.Id, student.FullName, subject.Name};

            /*Gom nhóm với toán tử group by*/
            //Gom nhóm theo tên môn học
            //var registerGroupQuery = from reg in registedStudentQuery
            //                         orderby reg.Name ascending
            //                         group reg by reg.Name;

            //foreach (var group in registerGroupQuery)
            //{
            //    Console.WriteLine($"{group.Key}");
            //    foreach (var item in group)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}

            //Gom nhóm theo tên địa chỉ
            var studentInAddressQuery = from student in students
                                        orderby student.Address ascending
                                        group student by student.Address;
            foreach (var group in studentInAddressQuery)
            {
                Console.WriteLine($"{group.Key}:"); //hiển thị ra key của group
                foreach (var item in group)
                {
                    Console.WriteLine(item);
                }
            }
        }

        struct Student
        {
            public string Id { get; set; }
            public string FullName { get; set; }
            public string Address { get; set; }
            public float[] Marks { get; set; }

            public Student(string id, string fullName, string address, float[] marks)
            {
                Id = id;
                FullName = fullName;
                Address = address;
                Marks = marks;
            }

            public override string ToString() => $"Student[{Id}, {FullName}, {Address}]";

            public override bool Equals(object obj)
            {
                return obj is Student student && Equals(student);
            }

            public bool Equals(Student other)
            {
                return Id == other.Id;
            }
            public override int GetHashCode()
            {
                return 2108858624 + EqualityComparer<string>.Default.GetHashCode(Id);
            }
        }
        struct Subject
        {
            public string Id { get; set; }
            public string Name { get; set; }
            public int Credit { get; set; }
        }

        struct Register : IEquatable<Register>
        {
            public string SubjectId { get; set; }
            public string StudentId { get; set; }
            public override bool Equals(object obj)
            {
                return obj is Register register && Equals(register);
            }
            public bool Equals(Register other)
            {
                return SubjectId == other.SubjectId &&
                       StudentId == other.StudentId;
            }
            public override int GetHashCode()
            {
                int hashCode = 1231936815;
                hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(SubjectId);
                hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(StudentId);
                return hashCode;
            }
        }
    }
}
