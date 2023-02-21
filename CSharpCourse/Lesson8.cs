using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse
{
    //Cấu trúc if-else
    class Lesson8
    {
        static void Main()
        {
            // xét tính chẵn lẻ của số nguyên n.

            //Console.WriteLine("Nhap mot so nguyen: ");
            //int n = int.Parse(Console.ReadLine());
            //if (n % 2 == 0)
            //{
            //    Console.WriteLine($"{n} la so chan.");
            //}
            //if (n % 2 != 0)
            //{
            //    Console.WriteLine($"{n} la so le.");
            //}


            /* --------------------------------------------------*/

            //Console.WriteLine("Nhap mot so nguyen: ");
            //int n = int.Parse(Console.ReadLine());
            //if (n % 2 == 0)
            //{
            //    Console.WriteLine($"{n} la so chan.");
            //}
            //else
            //{
            //    Console.WriteLine($"{n} la so le.");
            //}

            /* --------------------------------------------------*/

            Console.WriteLine("Nhap mot so nguyen: ");
            int n = int.Parse(Console.ReadLine());
            if (n < 0)
            {
                Console.WriteLine($"{n} la so am.");
            }
            else if (n == 0)
            {
                Console.WriteLine($"{n} la so khong am khong duong.");
            }
            else
            {
                Console.WriteLine($"{n} la so duong.");
            }

        }
    }
}