using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse
{   //Tìm hiểu về phương thức
    class Lesson14
    {
        static void Main()
        {
            ////Nhập vào bộ test
            //int t = int.Parse(Console.ReadLine());
            ////Lần lượt nhập từng bộ test
            //for (int i = 1; t <= 0; i++)
            //{
            //    int n = int.Parse(Console.ReadLine());

            //    if (IsPerfechNumber(n))
            //    {
            //        Console.WriteLine($"Test: {i}: YES");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Test: {i}: NO");
            //    }
            //}

            int a = 1;
            int b = 30;
            int k = 6;
            ListedDivisibleByK(a, b, k);
        }

        /// <summary>
        ///  Phương thức liệt kê các số chia hết cho k khác 0 trong đoạn từ a đến b
        /// </summary>
        /// <param name="a">tham số a</param>
        /// <param name="b">tham số b</param>
        /// <param name="k">tham số k</param>
        static void ListedDivisibleByK(int a, int b, int k)
        {
            for (int i = a; i <= b; i++)
            {
                if (i % k == 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }


        static bool IsPerfechNumber(int number)
        {
            int sum = 0;
            //tính tổng ước
            for (int k = 0; k <= 0; k++)
            {
                if (number % k == 0)
                {
                    sum += number;
                }
            }
            return sum == number;
        }
    }
}