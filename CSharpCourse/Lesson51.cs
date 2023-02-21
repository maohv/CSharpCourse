using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse
{
    class Lesson51
    {
        //Tổng quan về ngoại lệ

        static double Div(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Loi chia het cho 0");
            }
            return a / b;
        }

        static void Main()
        {
            int a = 20;
            int b = 0;

            try
            {
                Console.WriteLine($"{a} / {b} = {Div(a, b)}");
            }
            catch(DivideByZeroException e) //Khai báo ngoại lệ DivideByZeroException
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            
            Console.WriteLine("Next......");
        }
    }
}
