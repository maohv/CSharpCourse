using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse
{
    class Lesson18
    {
        //Phương thức, hàm cục bộ
        static void Main()
        {
            Console.WriteLine("From number: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("To number: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"Prime number from: {a} to {b}");
            ListedPrimeNumbers(a, b);
        }

        static void OtherMethod(int number)
        {
            int localVariable = 100;
            LocalFunc(); // Nếu thêm static sẽ không gọi đc

            void LocalFunc()
            {
                Console.WriteLine("This is a local function inside other method");
                Console.WriteLine(localVariable);
                Console.WriteLine(number);
            }
        }
        static void ListedPrimeNumbers(int from, int to)
        {
            bool IsPrime(int number)
            {
                if (number < 2)
                {
                    return false;
                }
                int bound = (int)Math.Sqrt(number);
                for (int i = 2; i <= bound; i++)
                {
                    if (number % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
            for (int i = from; i <= to; i++)
            {
                if (IsPrime(i))
                {
                    Console.Write($"{i} ");
                }
            }
            Console.WriteLine();

        }
    }
}