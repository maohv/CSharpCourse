using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse
{
    //Vòng lặp while và do-while
    class Lesson12
    {
        static void Main()
        {
            //int n = int.Parse(Console.ReadLine());
            //int m = n;
            //int SumDigits = 0;
            //while (n > 0)
            //{
            //    SumDigits += n % 10; // Tương đương SumDigits = SumDigits + (n % 10);
            //    n /= 10; // Tương đương n = n / 10
            //}
            //Console.WriteLine($"Tong cac chu so cua {m} : {SumDigits}");

            var data = Console.ReadLine().Split(' ');
            int a = int.Parse(data[0]);
            int b = int.Parse(data[1]);

            if (a <= 0 || b <= 0)
            {
                Console.WriteLine("INVALID");
            }
            else
            {
                int prod = a * b;
                // tìm ước chung
                while (a != b)
                {
                    if (a > b)
                    {
                        //a -= b;
                        a = a - b;
                    }
                    else
                    {
                        //b -= a;
                        b = b - a;
                    }
                }
                Console.WriteLine($"{a} {prod / a}");
            }

        }
    }
}