using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse
{
    class Lesson69
    {
        // Lớp LinkedList<T> danh sách liên kết đôi có sẵn của thư viện
        static void Main()
        {
            Console.OutputEncoding= Encoding.UTF8;
            var elements = new string[] {"Monday", "Tuesday", "Wednesday", "Thursday"};
            LinkedList<string> list = new LinkedList<string>(elements);
            Console.WriteLine($"Số phần tử của DSLK: {list.Count}");
            Console.WriteLine($"Số phần tử đầu của DSLK: {list.First.Value}");
            Console.WriteLine($"Số phần tử cuối của DSLK: {list.Last.Value}");
            Console.WriteLine($"Số phần tử tiếp theo của của phần tử First của DSLK: {list.First.Next.Value}");
            Console.WriteLine($"Phần tử liền trước của phần tử First của DSLK: {list.First.Previous}");
        }
    }
}
