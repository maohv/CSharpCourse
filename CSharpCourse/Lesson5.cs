using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse
{
    class Lesson5
    {
        //Các phép toán so sánh và logic
        static void Main()
        {
            int a = 5;
            int b = 6;
            int c = 7;
            Console.WriteLine($"a == b ? {a == b}"); //false
            Console.WriteLine($"a != b ? {a != b}"); //true
            Console.WriteLine($"a < b ? {a < b}"); //true
            Console.WriteLine($"a <= b ? {a <= b}"); //true
            Console.WriteLine($"a > b ? {a > b}"); //false
            Console.WriteLine($"a >= b ? {a >= b}"); //false
            Console.WriteLine($"a < b && a < c? {(a < b) && (a < c)}"); //true
            Console.WriteLine($"a > b || a > c? {(a > b) || (a > c)}"); //false
        }
    }
}