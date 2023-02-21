using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse
{
    class Lesson16
    {
        //Nạp chồng phương thức
        static void Main()
        {
            int a = 10;
            int b = 20;
            int c = 30;
            Console.WriteLine(Max(a, b, c));
        }

        static int Max(int a, int b)
        {
            return Max(a, b, Int32.MinValue);
        }

        static int Max(int a, int b, int c)
        {
            return Max(a, b, c, Int32.MinValue);
        }

        static int Max(int a, int b, int c, int d)
        {
            int max1 = Math.Max(a, b);
            int max2 = Math.Max(b, c);
            return Math.Max(max1, max2);
        }

        static long Max(long a, long b)
        {
            return a > b ? a : b;
        }

        static float Max(float a, float b)
        {
            return a > b ? a : b;
        }

        static double Max(double a, double b)
        {
            return a > b ? a : b;
        }

    }
}