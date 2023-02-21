using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse
{
    //Vòng lặp for
    class Lesson11
    {
        static void Main()
        {
            //Ví dụ:

            //Console.Write("Nhap vao so a:");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("Nhap vao so b:");
            //int b = int.Parse(Console.ReadLine());
            //Console.Write("Nhap vao so k:");
            //int k = int.Parse(Console.ReadLine());

            //Console.WriteLine($"Cac gia tri tu [{a} den {b}] chia het cho {k}:");
            //for (int i = a; i <= b; i++)
            //{
            //    if (i % k == 0)
            //    {
            //        Console.WriteLine(i + "");
            //    }
            //}
            //Console.WriteLine();

            int t = int.Parse(Console.ReadLine());

            for (int i = 1; i <= t; i++)
            {
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine($"TEST {i}:");
                if (n < 0)
                {
                    Console.WriteLine("NO RESULT");
                }
                else
                {
                    for (int j = 0; j <= n; j++) // xét j từ 0 đến n
                    {
                        if (j % 2 == 0) // nếu j là số chẵn
                        {
                            Console.Write(j + " "); // in ra
                        }
                    }
                    Console.WriteLine(); // in xuống dòng
                }
            }

        }
    }
}