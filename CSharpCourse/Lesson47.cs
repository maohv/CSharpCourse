using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CSharpCourse
{
    class Lesson47
    {
        //So khớp số điện thoại
        static void Main()
        {
            var pattern1 = @"^\+\d{2}-\d{3}-\d{3}-\d{3}$";
            //+84-705-050-399
            var pattern = @"^0(3|8|9\d{8})$";
            var regex = new Regex(pattern);
            Console.WriteLine("Nhap so dien thoai can kiem tra: ");
            var phoneNumber = Console.ReadLine();
            if (regex.IsMatch(phoneNumber))
            {
                Console.WriteLine("So dien thoai hop le");
            }
            {
                Console.WriteLine("So dien thoai k hop le");
            }
        }
    }
}
