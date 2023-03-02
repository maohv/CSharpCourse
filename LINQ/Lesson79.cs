using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Lesson79
    {
        /*
       * Các toán tử liên quan đến tập hợp của LINQ
       * 1. Loại bỏ phần tử trùng lặp trong 1 tập hợp
       * 2. Trả về các phần tử ở tập này nhưng không ở tập kia
       * 3. Trả về các phần tử chung trong 2 tập hợp
       * 4. Trả về các phần tử duy nhất xuất hiện ở tập hợp 1 hoặc tập hợp 2
       */
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            // danh sách sinh viên
            var Students1 = new List<Student>()
            {
                new Student("B25DCCN107", "Trần Trung Đức", "Hà Nội"),
                new Student("B25DCCN100", "Trần Trung Đức", "Cao Bằng"),
                new Student("B25DCCN100", "Trần Trung Đức", "Cao Bằng"),
                new Student("B25DCCN105", "Lê Khả Ngân", "Nam Định"),
                new Student("B25DCCN103", "Hoàng Thanh Mai", "Đà Nẵng"),
                new Student("B25DCCN103", "Hoàng Thanh Mai", "Đà Nẵng"),
                new Student("B25DCCN109", "Nguyễn Thúy Quyên", "Hà Nội"),
                new Student("B25DCCN106", "Nông Tiến Mạnh", "Thái Nguyên"),
                new Student("B25DCCN106", "Nông Tiến Mạnh", "Thái Nguyên"),
                new Student("B25DCCN101", "Hồ Hoài Anh", "Hà Nội"),
                new Student("B25DCCN104", "Trương Thanh Thức", "Hồ Chí Minh"),
                new Student("B25DCCN104", "Trương Thanh Thức", "Hồ Chí Minh"),
                new Student("B25DCCN108", "Đỗ Hoàng Long", "Hồ Chí Minh")
            };

            var Students2 = new List<Student>()
            {
                new Student("B25DCCN107", "Trần Trung Đức", "Hà Nội"),
                new Student("B25DCCN100", "Trần Trung Đức", "Cao Bằng"),
                new Student("B25DCCN110", "Trần Trung Dũng", "Thái Bình"),
                new Student("B25DCCN104", "Trương Thanh Thức", "Hồ Chí Minh"),
                new Student("B25DCCN108", "Đỗ Hoàng Long", "Hồ Chí Minh")
            };

            // 4: Union
            var unionStudent1sQuery = from Student1 in Students1.Union(Students2)
                                     orderby Student1.Id ascending
                                     select Student1;

            foreach (var item in unionStudent1sQuery)
            {
                Console.WriteLine(item);
            }

            //// 3: Intersec
            //var intersecStudent1sQuery = from Student1 in Student1s1.Intersect(Student1s2)
            //                            select Student1;
            //foreach (var item in intersecStudent1sQuery)
            //{
            //    Console.WriteLine(item);
            //}

            //// 2: Except
            //var exceptStudent1sQuery = from Student1 in Student1s1.Except(Student1s2)
            //                          select Student1;
            //foreach (var item in exceptStudent1sQuery)
            //{
            //    Console.WriteLine(item);
            //}

            //// 1: Distinct or DistincBy
            //var distinctStudent1sQuery = from Student1 in Student1s1.Distinct()
            //                            select Student1;
            //foreach (var item in distinctStudent1sQuery)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }

}
