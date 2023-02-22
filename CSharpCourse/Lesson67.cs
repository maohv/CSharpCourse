using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse
{
    class Lesson67
    {
        //Tìm hiểu và sử dụng lớp Stack<T>
        static void Main()
        {
            Console.OutputEncoding= Encoding.UTF8;
            Stack<string> stack1 = new Stack<string>();
            Stack<string> stack2 = new Stack<string>(new string[] {"one", "two", "three"});
            Console.WriteLine($"=> Số phần tử trong stack: {stack2.Count}");
            stack2.Push("four"); //thêm phần tử vào stack
            //stack2.Clear(); //xóa toàn bộ phần tử
            //stack2.Contains("one"); //tìm kiếm phần tử trong stack có hay ko
            Console.WriteLine($"=> Phần tử top: {stack2.Peek()}");
            stack2.Pop();//xóa bỏ 1 phần tử
            Console.WriteLine($"=> Phần tử top: {stack2.Peek()}");

            Console.WriteLine("=> các phần tử có trong stack");
            var elements = stack2.ToArray();
            foreach (var item in elements)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Phần tử \"three\" có tồn tại trong stack? " + stack2.Contains("three"));
        }
    }
}
