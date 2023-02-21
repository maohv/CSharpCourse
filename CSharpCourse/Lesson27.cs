using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse
{
    class Lesson27
    {
        //Biểu thức lambda
        static void Main()
        {
            //// định nghĩa một biểu thức lamdba và gán cho bién action
            //var action = () => Console.WriteLine("Hello :))");
            //action();

            ////câu lệnh lambda tìm giá trị max trong 3 số
            //var findMax = (int a, int b, int c) =>
            //{
            //    int max = a;
            //    if (max < a)
            //    {
            //        max = b;
            //    }
            //    if (max < c)
            //    {
            //        max = c;
            //    }
            //    return max;
            //};

            //int maxValue = findMax(1, 2, 3);
            //Console.WriteLine($"Max value is: {maxValue}");

            //int[] numbers = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //var countOddNumber = (int[] arr) =>
            //{
            //    int counter = 0;
            //    foreach (var item in arr)
            //    {
            //        if (item % 2 != 0)
            //        {
            //            counter++;
            //        }
            //    }
            //    return counter;
            //};

            //var result = countOddNumber(numbers);
            //Console.WriteLine("Number of odd element in array: "+ result);




            //====Chuyển đổi lamdba sang kiểu delegate ====

            Action<string> action = (msg) => Console.WriteLine(msg);
            action("Hello World");


            Func<int, int, int, int> findMax = (a, b, c) =>
            {
                int max = a;
                if (max < a)
                {
                    max = b;
                }
                if (max < c)
                {
                    max = c;
                }
                return max;
            };

            int maxValue = findMax(1, 2, 3);
            Console.WriteLine($"Max value is: {maxValue}");

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Func<int[], int> countOddNumber = (arr) =>
            {
                int counter = 0;
                foreach (var item in arr)
                {
                    if (item % 2 != 0)
                    {
                        counter++;
                    }
                }
                return counter;
            };

            var result = countOddNumber(numbers);
            Console.WriteLine("Number of odd element in array: " + result);
        }
    }
}