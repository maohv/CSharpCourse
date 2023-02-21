using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse
{
    class Lesson25
    {
        //Lớp Array
        static void Main()
        {
            int[] arr1 = { 1, 2, 3, 6, 7, 4, 5, 8, 9, 10, 12, 20, 23, 14 };
            Console.WriteLine("Mang arr1 truoc sap xep: ");
            ShowElements(arr1);
            Console.WriteLine("Mang arr1 sau sap xep: ");
            Array.Sort(arr1, 0, 5); //sắp xếp từ vị trí 0 - 5
            ShowElements(arr1);
            //Console.WriteLine("Dao nguoc mang arr1: ");
            //Array.Reverse(arr1);
            //ShowElements(arr1);

            //Console.WriteLine("Nhap x can tim trong mang: ");
            //int x = int.Parse(Console.ReadLine());
            //Console.WriteLine(Array.BinarySearch(arr1, x) >= 0 ? "Ton tai " : "Khong tan tai x");

            //Array.Clear(arr1, 0, arr1.Length);
            //Console.WriteLine("kich thuoc mang sau khi clear: "+ arr1.Length);
            //Console.WriteLine("Gia tri phan tu sau khi clear: ");
            //ShowElements(arr1);

            Console.WriteLine("Gia tri sau khi coppy: ");
            int[] arr2 = new int[20];
            arr1.CopyTo(arr2, 5); // coppy và thêm vào bắt đầu vị trí = 5 của mảng arr2
            ShowElements(arr2);
        }

        static void ShowElements(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}