using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse
{
    class Lesson20
    {
        //Phương thức đệ quy
        static void Main()
        {
            Console.WriteLine("Nhap vao so nguyen dung n: ");
            // n! = n * (n-1)!
            uint n = uint.Parse(Console.ReadLine());
            Console.WriteLine($"{n}! = {Factorial(n)}");
            // Sn = n + Sn-1 = n + n-1 + Sn -2
            Console.WriteLine("Nhap vao so nguyen duong k: ");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine($"S{k} = 1 + 2 + ... + {k}: {Sum(k)}");
        }


        static int Sum(int n)
        {
            if (n == 1)
            {
                return n;
            }
            else
            {
                return n + Sum(n - 1);
            }
        }

        static ulong Factorial(uint n)
        {
            if (n == 0 || n == 1)
            {
                return 1; // điểm dừng
            }
            else
            {
                return n * Factorial(n - 1); // lời gọi đệ quy
            }
        }
    }
}