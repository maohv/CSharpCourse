using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse
{
    class Lesson26
    {
        //Kiểu giá trị có thể null
        static void Main()
        {
            //bool? isOk = null; //true, false
            //double? pi = 3.14;
            //int?[] arr = new int?[10]; //mảng đc khởi tạo giá trị null
            //int x = 200;
            //int? y = x;

            //int? number1 = 100;
            //int? number2 = null;
            //if (number1.HasValue)
            //{
            //    Console.WriteLine($"Gia tri trong number1: {number1.Value}");
            //}
            //else
            //{
            //    Console.WriteLine("Gia tri trong number1 la null.");
            //}


            //int? number1 = 100;
            //int? number2 = null;
            //int x = number1; //error
            //int y = number1 ?? -1; //ok, y = 100
            //int z = number2 ?? -1; //ok, z = -1

            int? number1 = 100;
            int? number2 = null;
            int? number3 = 200;
            //phép cộng
            //number1++; //ok number1 tăng lên 101
            //number1 += number3; //number3 sẽ là 301
            //number1 += number2; //null
            // so sánh
            Console.WriteLine($"number1 > number2? {number1 > number2} "); //false
            Console.WriteLine($"number1 < number2? {number1 < number2} "); //false
            Console.WriteLine($"number1 >= number2? {number1 >= number2} "); //false
            Console.WriteLine($"number1 == number2? {number1 == number2} "); //false
            Console.WriteLine($"number1 != number2? {number1 != number2} "); //true
            Console.WriteLine($"number1 == null? {number2 == null} "); //true
            Console.WriteLine($"number1 == null? {number2 != null} "); //false
        }
    }
}