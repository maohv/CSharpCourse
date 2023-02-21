using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse
{
    class Lesson23
    {
        //Sắp xếp trên mảng
        static void Main()
        {
            int[] arr = { 1, 5, 0, 2, 3, 2, 4, 5, 9, 6, 7, 4, 8 };
            Console.WriteLine("Truoc sap xep: ");
            ShowArray(arr);
            QuickSort(arr, 0, arr.Length - 1);
            Console.WriteLine("Sau sap xep: ");
            ShowArray(arr);
        }

        static void QuickSort(int[] arr, int leftIndex, int rightIndex)
        {
            if (leftIndex < rightIndex)
            {
                int p = Partition(arr, leftIndex, rightIndex);
                QuickSort(arr, leftIndex, p - 1);
                QuickSort(arr, p + 1, rightIndex);
            }
        }

        static int Partition(int[] arr, int leftIndex, int rightIndex)
        {
            int pivot = arr[rightIndex];
            int i = leftIndex;
            for (int j = leftIndex; j <= rightIndex; j++)
            {
                if (arr[j] < pivot)
                {
                    int tmp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = tmp;
                    i++;
                }
            }
            Swap(ref arr[i], ref arr[rightIndex]);
            return i;
        }

        static void Swap(ref int a, ref int b)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }

        // Phương thức hiển thị các phần tử trong mảng
        static void ShowArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}