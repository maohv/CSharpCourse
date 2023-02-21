using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse
{
    class Lesson1
    {
        static void Main()
        {
            Console.WriteLine($"Gia tri max cua kieu int: {Int32.MaxValue}");
            Console.WriteLine($"Gia tri min cua kieu int: {Int32.MinValue}");
            Console.WriteLine($"Gia tri max cua kieu long: {Int64.MaxValue}");
            Console.WriteLine($"Gia tri min cua kieu long: {Int64.MinValue}");
            Console.WriteLine($"Gia tri max cua kieu ulong: {UInt64.MaxValue}");
            Console.WriteLine($"Gia tri min cua kieu ulong: {UInt64.MinValue}");
            string fullName = "Tran Van Nam";
            bool isMarried = true;
            int age = 21;
            Console.WriteLine("Hello " + fullName);
            Console.WriteLine(age);
            Console.WriteLine(isMarried);
        }
    }
}