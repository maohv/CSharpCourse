using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CSharpCourse
{
    class Lesson46
    {
        //So khớp địa chỉ email
        static void Main()
        {
            var pattern = @"^[a-z0-9_]+[a-z0-9.-_]+\@[a-z0-9]+\.[a-z]{2,4}$"; //bắt đầu bằng a-z 0-9 dấu _, + một hoặc nhiều
            var regex = new Regex(pattern, RegexOptions.IgnoreCase); //RegexOptions.IgnoreCase k phân biệt hoa thường
            Console.WriteLine("Nhap email can kiem tra");
            var email = Console.ReadLine();
            if (regex.IsMatch(email))
            {
                Console.WriteLine("Email hop le");
            }
            else
            {
                Console.WriteLine("Email ko hop le");
            }
        }
    }
}
