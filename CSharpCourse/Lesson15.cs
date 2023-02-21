using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse
{
    class Lesson15
    {
        //Tìm hiểu về tham số ref, in, out
        static void Main()
        {
            //int a = 20;
            //int b = 50;
            //Console.WriteLine($"Before change a = {a}, b = {b}");
            //Swap(ref a, ref b);
            //Console.WriteLine($"After change a = {a}, b = {b}");


            //string message = "Hello world";
            //PrintMessage(in message);


            int[] numbers = { 1, 3, 2, 5, 8, 4, 6, 9, 7 };
            ref int maxValue = ref FindMax(numbers);
            maxValue *= 2;
            ref int newMaxValue = ref FindMax(numbers);
            Console.WriteLine(newMaxValue);

        }

        static ref int FindMax(int[] arr)
        {
            int max = arr[0];
            int maxValueIndex = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                    maxValueIndex = i;
                }
            }
            return ref arr[maxValueIndex];
        }



        static void PrintMessage(in string message)
        {
            Console.WriteLine(message);

        }

        static void Swap(ref int first, ref int second)
        {
            int tmp = first;
            first = second;
            second = tmp;
        }
    }
}