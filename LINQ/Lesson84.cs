using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Lesson84
    {
        //Các toán tử element
        static void Main()
        {

            Console.OutputEncoding = Encoding.UTF8;
            // danh sách môn học
            var subjects = new List<Subject>()
            {
                new Subject{Id="SJ1001", Name="C++", Credit=3},
                new Subject{Id="SJ1002", Name="C#", Credit=3},
                new Subject{Id="SJ1003", Name="Java", Credit=4},
                new Subject{Id="SJ1004", Name="SQL", Credit=3},
                new Subject{Id="SJ1005", Name="Python", Credit=3},
                new Subject{Id="SJ1006", Name="Kotlin", Credit=4},
                new Subject{Id="SJ1007", Name="JavaScript", Credit=2},
            };
            Console.WriteLine("=> phần tử đầu tiên trong danh sách:");
            Console.WriteLine(subjects.First());
            Console.WriteLine("=> phần tử >=4 trong danh sách:");
            Console.WriteLine(subjects.First(x => x.Credit >=4));
            Console.WriteLine("=> phần cuối >=4 trong danh sách:");
            Console.WriteLine(subjects.Last(x => x.Credit >=4));
            Console.WriteLine("1 phần tử = 2");
            Console.WriteLine(subjects.Single(x => x.Credit == 2));
            Console.WriteLine("Trả về vị trí thứ 3 trong phần tử:");
            Console.WriteLine(subjects.ElementAt(3));
            Console.WriteLine("Trả về đối tượng mặc định khi không tìm thấy: ");
            Console.WriteLine(subjects.FirstOrDefault(x => x.Credit >=5 ));



        }
        struct Subject
        {
            public string Id { get; set; }
            public string Name { get; set; }
            public int Credit { get; set; }
            public override string ToString()
            {
                return $"Subject[{Id}, {Name}, {Credit}]";
            }
        }
    }
}
