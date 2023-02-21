using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse
{
    class Lesson24
    {
        //Tìm kiếm trên mảng
        static void Main()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 8, 9, 7, 5, 8 };
            Array.Sort(arr);
            Console.WriteLine("Nhap x can tim: ");
            int x = int.Parse(Console.ReadLine());
            var result = BinarySearch(arr, x, 0, arr.Length - 1);
            Console.WriteLine($"{x}{(result >= 0 ? "" : " Khong")} ton tai trong mang");
        }

        static int BinarySearch(int[] arr, int x, int left, int right)
        {
            if (left < right)
            {
                int mid = left + (right - left) / 2;
                if (arr[mid] == x)
                {
                    return mid;
                }
                if (arr[mid] < x)
                {
                    return BinarySearch(arr, x, mid + 1, right);
                }
                else
                {
                    return BinarySearch(arr, x, left, mid - 1);
                }
            }
            return -1;
        }
    }
}