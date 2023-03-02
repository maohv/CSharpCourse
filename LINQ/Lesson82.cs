using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Lesson82
    {
        //Các toán tử projection
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            // danh sách sinh viên
            var students = new List<Student2>()
            {
                new Student2("B25DCCN107", "Trần Trung Đức", "Hà Nội", new float[] {3.21f, 3.29f, 3.54f}),
                new Student2("B25DCCN100", "Trần Văn Đức", "Cao Bằng", new float[] {3.66f, 3.37f, 3.88f}),
                new Student2("B25DCCN105", "Lê Khả Ngân", "Nam Định", new float[] {3.78f, 3.18f, 3.42f}),
                new Student2("B25DCCN103", "Hoàng Thanh Mai", "Đà Nẵng", new float[] {3.54f, 3.46f, 3.74f}),
                new Student2("B25DCCN109", "Nguyễn Thúy Quyên", "Hà Nội", new float[] {3.36f, 3.05f, 3.18f}),
                new Student2("B25DCCN106", "Nông Tiến Mạnh", "Thái Nguyên", new float[] {3.45f, 3.51f, 3.88f}),
                new Student2("B25DCCN101", "Hồ Hoài Anh", "Hà Nội", new float[] {3.69f, 3.35f, 3.68f}),
                new Student2("B25DCCN104", "Trương Thanh Thức", "Hồ Chí Minh", new float[] {3.11f, 3.18f, 3.72f}),
                new Student2("B25DCCN108", "Đỗ Hoàng Long", "Hồ Chí Minh", new float[] {3.88f, 3.97f, 3.49f})
            };

            //var fullNameQuery = from student in students
            //                    select student.FullName;

            //var fullNameQuery = students.Select(s => s.FullName);

            //foreach (var item in fullNameQuery)
            //{
            //    Console.WriteLine(item);
            //}

            var maxMarkQuery = from student in students
                               from mark in student.Marks
                               where mark == student.Marks.Max()
                               select new { student.Id, student.FullName, mark };
            foreach (var item in maxMarkQuery)
            {
                Console.WriteLine(item);
            }
        }
    }
    struct Student2
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public float[] Marks { get; set; }

        public Student2(string id, string fullName, string address, float[] marks)
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
}
