using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse
{
    class Lesson4
    {
        //Các toán tử trong lập trình C#
        static void Main()
        {
            float a = 20.25f;
            int b = 30;
            var sum = a + b; // sum kiểu float
            Console.WriteLine(sum);
            Console.WriteLine(sum.GetType().Name);
            // phép chia
            Console.WriteLine(1.0 * 2 / 3);
            Console.WriteLine(2.0 / 3);
            Console.WriteLine(-2 / 0.0);
            // ví dụ ép kiểu
            int x = 2;
            int y = 3;
            Console.WriteLine((float)x / y);
            Console.WriteLine(a % b);
            Console.WriteLine(-2 % -3);

            // phép tăng giảm ++ --
            x = 1;
            y = x++; // Gán cho x cho y trước sau tăng giá trị của x =>  y = 1, x = 2
            int z = --y; // Giảm giá trị của y trước sau đó mới gán giá trị cho z => y = 0, z = 0
            Console.WriteLine($"x = {x}, y = {y}, z = {z}");
            string str1 = "Today";
            string str2 = " is Monday";
            var str = str1 + str2;
            Console.WriteLine(str);
            x = 5;
            x += 5;
            Console.WriteLine(x);
        }
    }
}