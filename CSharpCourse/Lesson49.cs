using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CSharpCourse
{
    class Lesson49
    {
        //So khớp họ và tên
        static void Main()
        {
            var pattern = @"^[\p{L} ]{2,40}$";
            var regex = new Regex(pattern, RegexOptions.IgnoreCase);
            Console.WriteLine("Ho va ten: ");
            var fullName = Console.ReadLine().Trim();
            if (regex.IsMatch(fullName))
            {
                Console.WriteLine("Ho va ten hop le.");
            }
            else
            {
                Console.WriteLine("Ho va ten khong hop le.");
            }
        }
    }
}
