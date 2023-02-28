using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LINQ
{
    class Lesson77
    {
        //Cú pháp truy vấn và cú pháp phương thức trong LINQ
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            // danh sách sinh viên
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

            // danh sách giáo viên
            var teachers = new List<Teacher>() {
                new Teacher("T001", "Mai Thu Huyền", "Hà Nội", 24500000),
                new Teacher("T003", "Hoàng Quốc Trung", "Hà Nội", 16500000),
                new Teacher("T002", "Lê Tấn Tài", "Đà Nẵng", 18500000),
                new Teacher("T004", "Lê Mỹ Hạnh", "Hà Nội", 19500000),
                new Teacher("T005", "Trần Thanh Tuấn", "Hồ Chí Minh", 17800000)
            };

            //var peopleInHanoiQuery = from student in students
            //                         where student.Address == "Hà Nội"
            //                         select student;

            //cú pháp tương tự
            //var peopleInHanoiQuery = students.Where(student => student.Address == "Hà Nội").Select(student => student);

            //foreach (var item in peopleInHanoiQuery)
            //{
            //    Console.WriteLine(item);
            //}

            //chuyển đối tương sinh viên sang XML cú pháp tương tự lesson76
            //var studentToXML = new XElement("students",
            //    students.Select(student => new XElement("students",
            //               new XElement("Id", student.Id),
            //               new XElement("FullName", student.FullName),
            //               new XElement("Address", student.Address)
            //               ))
            //   );

            //Console.WriteLine(studentToXML);


            //var TeachersQuery = from teacher in teachers
            //                    orderby teacher.Salary descending
            //                    select new { teacher.FullName, teacher.Salary };

            //cú pháp tương tự
            var TeachersQuery = teachers.Select(t => t).OrderBy(t => t.Salary).Reverse();
            foreach (var item in TeachersQuery)
            {
                Console.WriteLine(item);
            }
        }
    }
}
