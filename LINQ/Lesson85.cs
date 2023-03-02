using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Lesson85
    {
        //Các toán tử aggregation
        /**
         * Các toán tử tổng hợp
         * 1. Average
         * 2. Count
         * 3. Max
         * 4. Min
         * 5. Sum
         */
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            float[] temps = new float[] { 26.5f, 30.0f, 28.5f,
                29.5f, 29.0f, 31.5f, 27.5f };
            var students = new List<Student2>()
            {
                new Student2("B25DCCN107", "Trần Trung Đức", "Hà Nội",
                    new float[] {3.21f, 3.29f, 3.54f}),
                new Student2("B25DCCN100", "Trần Văn Đức", "Cao Bằng",
                    new float[] {3.66f, 3.37f, 3.88f}),
                new Student2("B25DCCN105", "Lê Khả Ngân", "Nam Định",
                    new float[] {3.78f, 3.18f, 3.42f}),
                new Student2("B25DCCN103", "Hoàng Thanh Mai", "Đà Nẵng",
                    new float[] {3.54f, 3.46f, 3.74f}),
                new Student2("B25DCCN109", "Nguyễn Thúy Quyên", "Hà Nội",
                    new float[] {3.36f, 3.05f, 3.18f}),
                new Student2("B25DCCN106", "Nông Tiến Mạnh", "Thái Nguyên",
                    new float[] {3.45f, 3.51f, 3.88f}),
                new Student2("B25DCCN101", "Hồ Hoài Anh", "Hà Nội",
                    new float[] {3.69f, 3.35f, 3.68f}),
                new Student2("B25DCCN104", "Trương Thanh Thức", "Hồ Chí Minh",
                    new float[] {3.11f, 3.18f, 3.72f}),
                new Student2("B25DCCN108", "Đỗ Hoàng Long", "Hồ Chí Minh",
                    new float[] {3.88f, 3.97f, 3.49f})
            };

            //Console.WriteLine($"Nhiệt độ trung bình tuần: {temps.Average(), 2:f}");
            //Console.WriteLine($"Nhiệt độ cao nhất trong tuần: {temps.Max()}");
            //Console.WriteLine($"Nhiệt độ thấp nhất nhất trong tuần: {temps.Min()}");
            //Console.WriteLine($"Số phần tử của mảng: {temps.Count()}");
            //Console.WriteLine($"Tổng nhiệt độ trong tuần: {temps.Sum()}");

            var studyResultQuery = from student in students
                                   let gpa = Math.Round(student.Marks.Average(), 2) //Làm tròn đến 2 chữ số
                                   select new { student.Id, student.FullName, gpa};

            foreach (var item in studyResultQuery)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("=====================================");
            var maxMarkQuery = from student in students
                               let max = student.Marks.Max()
                               orderby max descending
                               select new { student.Id, student.FullName, max };

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
            return obj is Student2 student && Equals(student);
        }

        public bool Equals(Student2 other)
        {
            return Id == other.Id;
        }

        public override int GetHashCode()
        {
            return 2108858624 + EqualityComparer<string>.Default.GetHashCode(Id);
        }
    }
}
