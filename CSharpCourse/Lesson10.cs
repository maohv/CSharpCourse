using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse
{
    //Toán tử ba ngôi
    class Lesson10
    {
        static void Main()
        {
            // Ví dụ:
            //int n = int.Parse(Console.ReadLine());
            //string result = n % 2 == 0 ? $"{n} la so chan" : $"{n} la so le";
            //Console.WriteLine(result);

            //int n = int.Parse(Console.ReadLine());
            //string result = n < 0 ? "la so am" : n == 0 ? "khong am, khong duong" : "so duong";
            //Console.WriteLine(result);

            int n = int.Parse(Console.ReadLine());
            string output = n % 2 == 0 ? $"EVEN" : $"ODD";
            Console.WriteLine(output);

        }
    }
}