using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Lesson80
    {
        /*
        * Lọc dữ liệu với toán tử where của LINQ
        */
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            var students = new List<Student2>()
            {
                new Student2("B25DCCN107", "Trần Trung Đức", "Hà Nội", 3.21f),
                new Student2("B25DCCN100", "Trần Trung Đức", "Cao Bằng", 3.66f),
                new Student2("B25DCCN105", "Lê Khả Ngân", "Nam Định", 3.78f),
                new Student2("B25DCCN103", "Hoàng Thanh Mai", "Đà Nẵng", 3.54f),
                new Student2("B25DCCN109", "Nguyễn Thúy Quyên", "Hà Nội", 3.36f),
                new Student2("B25DCCN106", "Nông Tiến Mạnh", "Thái Nguyên", 3.45f),
                new Student2("B25DCCN101", "Hồ Hoài Anh", "Hà Nội", 3.69f),
                new Student2("B25DCCN104", "Trương Thanh Thức", "Hồ Chí Minh", 3.11f),
                new Student2("B25DCCN104", "Trương Thanh Thức", "Hồ Chí Minh", 3.39f),
                new Student2("B25DCCN108", "Đỗ Hoàng Long", "Hồ Chí Minh", 3.88f)
            };

            //var studentGpaQuery = from student in students
            //                      where student.Gpa >= 3.2 && student.Address == "Hà Nội"
            //                      select student;
            //foreach (var item in studentGpaQuery)
            //{
            //    Console.WriteLine(item);
            //}

            var pattern = @".*h.*";
            var regex = new Regex(pattern, RegexOptions.IgnoreCase);
            var resultQuery = from student in students
                              where regex.IsMatch(student.FullName)
                              select student;

            foreach (var item in resultQuery)
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
        public float Gpa { get; set; }
        public Student2(string id, string fullName, string address, float gpa)
        {
            Id = id;
            FullName = fullName;
            Address = address;
            Gpa = gpa;
        }
        public override string ToString() => $"Student[{Id}, {FullName}, {Address}, {Gpa}]";
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
