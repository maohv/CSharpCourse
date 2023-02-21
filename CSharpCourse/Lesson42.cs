using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExtensions
{
    public static class Extensions
    {
        public static int CountWord(this string str)
        {
            var spliter = new char[] { ' ', ',', '\t', '.', '?', '!', ':', ';' };
            var data = str.Split(spliter, StringSplitOptions.RemoveEmptyEntries); //StringSplitOptions.RemoveEmptyEntries 1 từ sau khi tách có độ dài = 0 thì k thêm vào tập kết quả data
            return data.Length;
        }

        public static string[] SplitWord (this string str)
        {
            var spliter = new char[] { ' ', ',', '\t', '.', '?', '!', ':', ';' };
            var data = str.Split(spliter, StringSplitOptions.RemoveEmptyEntries); //StringSplitOptions.RemoveEmptyEntries 1 từ sau khi tách có độ dài = 0 thì k thêm vào tập kết quả data
            return data;
        }
    }
}


namespace CSharpCourse
{
    using CustomExtensions;
    class Lesson42
    {
        //Phương thức mở rộng
        static void Main()
        {
            Console.WriteLine("Nhap vao chuoi ki tu: ");
            var input = Console.ReadLine();
            Console.WriteLine("Chuoi ki tu la: ");
            foreach (var item in Extensions.SplitWord(input))
            {
                Console.Write(item + " ");
            }
            Console.WriteLine($"\nCac tu dc in ra tu chuoi ki tu {Extensions.CountWord(input)}");
        }
       
      

    }
}
