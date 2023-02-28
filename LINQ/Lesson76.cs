using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LINQ
{
    class Lesson76
    {
        //Chuyển đổi kiểu trong truy vấn LINQ
        static void Main()
        {
            /*
            Chuyển đổi dữ liệu với LINQ
            1. Nối nhiều tập đầu vào thành một tập kết quả đầu ra.
            2. Tạo tập kết quả đầu ra chứa chỉ một vài thuộc tính từ tập đối tượng gốc.
            3. Tạo tập kết quả đầu ra là hệ quả của thao tác tính toán nào đó từ tập đầu vào.
            4. Tạo tập kết quả đầu ra ở định dạng khác, ví dụ XML.
            */

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
            var teachers = new List<Teacher>()
                {
                new Teacher("T001", "Mai Thu Huyền", "Hà Nội", 24500000),
                new Teacher("T003", "Hoàng Quốc Trung", "Hà Nội", 16500000),
                new Teacher("T002", "Lê Tấn Tài", "Đà Nẵng", 18500000),
                new Teacher("T004", "Lê Mỹ Hạnh", "Hà Nội", 19500000),
                new Teacher("T005", "Trần Thanh Tuấn", "Hồ Chí Minh", 17800000)
                };


            //Ví dụ 1:
            var peopleHaNoiQuery = (from student in students
                                    where student.Address == "Hà Nội"
                                    select student.FullName).Concat(from teacher in teachers             //Nối với kết quả thứ 2
                                                                    where teacher.Address == "Hà Nội"
                                                                    select teacher.FullName);
            foreach (var item in peopleHaNoiQuery)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("===================================");
            //ví dụ 2:
            var teacherSalatyQuery = from teacher in teachers
                                     orderby teacher.Salary descending
                                     select teacher.Salary;

            foreach (var item in teacherSalatyQuery)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("===================================");
            //ví dụ 3:
            var teacherSalatyQuery1 = teachers.Select(t => $"Lương thực lĩnh của mọi người làm có 20 ngày: {t.Salary * 20 / 22}");

            foreach (var item in teacherSalatyQuery1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("===================================");
            //ví dụ 4:
            var studentToXML = new XElement("students",
                from student in students
                select new XElement("students",
                            new XElement("Id", student.Id),
                            new XElement("FullName", student.FullName),
                            new XElement("Address", student.Address)
                            )
                );

            Console.WriteLine(studentToXML);

        }
    }
}
