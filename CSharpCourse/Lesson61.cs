using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse
{
    class Lesson61
    {
        //Lớp List<T>
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            //int[] numbers = new int[] { 1, 9, 3, 6, 5, 4, 8, 7, 2 };
            //List<int> list = new List<int>(numbers);
            //Console.WriteLine("Khả năng lưu trữ của list: " + list.Capacity);
            //Console.WriteLine("Số phần tử hiện có của list: " + list.Count);
            //list[3] = 500;
            //Console.WriteLine($"Phần tử tại vị trí 1: {list[1]}");
            //list.Add(200);
            //list.Add(100);
            //list.Add(900);
            //list.Insert(5, 800);
            //Console.WriteLine("Các phần tử của list: ");
            ////for (int i = 0; i < list.Count; i++)
            ////{
            ////    Console.Write(list[i] + " ");
            ////}
            ////foreach (var item in list)
            ////{
            ////    Console.Write(item + " ");
            ////}
            //list.ForEach(x => Console.Write(x + " "));
            //Console.WriteLine();

            List<string> friends = new List<string>();
            friends.Add("Mai");
            friends.Add("Mây");
            friends.Add("Minh");
            friends.Add("Mạnh");
            friends.Add("Oanh");
            friends.Add("Nhân");
            friends.Add("Hướng");
            friends.Add("Trung");
            friends.Add("Ánh");
            friends.Add("Cảnh");
            Console.WriteLine("Trước khi sắp xếp: ");
            friends.ForEach(x => Console.Write(x + " "));
            Console.WriteLine();
            friends.Sort(CompareByLengthDESC);
            // friends.Reverse();
            Console.WriteLine("Sau khi sắp xếp: ");
            friends.ForEach(x => Console.Write(x + " "));
            Console.WriteLine();
        }

        static int CompareASC(string str1, string str2)
        {
            return str2.CompareTo(str1);
        }
        // phương thức hỗ trợ sắp xếp theo thứ tự tăng dần độ dài từ
        static int CompareByLengthASC(string str1, string str2)
        {
            return str1.Length - str2.Length; // kết quả > 0 => đổi chỗ
        }
        // phương thức hỗ trợ sắp xếp theo thứ tự giảm dần độ dài từ
        static int CompareByLengthDESC(string str1, string str2)
        {
            return str2.Length - str1.Length; // kết quả > 0 => đổi chỗ
        }
    
    }
}
