using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Lesson75
    {
        //Các toán tử truy vấn LINQ cơ bản
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            var students = new List<Student>()
            {
                new Student("B25DCCN100", "Trần Trung Đức", "Hà Nội"),
                new Student("B25DCCN105", "Lê Khả Ngân", "Nam Định"),
                new Student("B25DCCN103", "Hoàng Thanh Mai", "Đà Nẵng"),
                new Student("B25DCCN109", "Nguyễn Thúy Quyên", "Hà Nội"),
                new Student("B25DCCN106", "Nông Tiến Mạnh", "Thái Nguyên"),
                new Student("B25DCCN101", "Hồ Hoài Anh", "Hà Nội"),
                new Student("B25DCCN104", "Trương Thanh Thức", "Hồ Chí Minh")
            };

            var registers = new List<RegisteredSubject>() {
                new RegisteredSubject("B25DCCN100", "Java", DateTime.Now),
                new RegisteredSubject("B25DCCN100", "C#", DateTime.Now),
                new RegisteredSubject("B25DCCN100", "SQL", DateTime.Now),
                new RegisteredSubject("B25DCCN105", "Android", DateTime.Now),
                new RegisteredSubject("B25DCCN104", "C#", DateTime.Now),
                new RegisteredSubject("B25DCCN101", "C#", DateTime.Now)
            };

            //var studentInHanoiQuery = from student in students
            //                          where student.Address == "Hà Nội"
            //                          orderby student.Id ascending
            //                          select student;

            //foreach (var item in studentInHanoiQuery)
            //{
            //    Console.WriteLine(item);
            //}


            //var groupStudentQuery = from student in students
            //                        group student by student.Address;
            //foreach (var group in groupStudentQuery)
            //{
            //    Console.WriteLine($"==> {group.Key}");
            //    foreach (var student in group)
            //    {
            //        Console.WriteLine(student);
            //    }
            //}

            //nối giữa 2 thằng Student và RegisteredSubject
            var StudentRegistedQuery = from student in students
                                       join register in registers on student.Id equals register.StudentId
                                       select new { student.Id, student.FullName, register.SubjectName };

            foreach (var item in StudentRegistedQuery)
            {
                Console.WriteLine($"{item.Id} - {item.FullName} - {item.SubjectName}");
            }
        }
    }
   
   
}
