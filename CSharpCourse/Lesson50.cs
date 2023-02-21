using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CSharpCourse
{
    class Lesson50
    {
        //So khớp ngày tháng năm sinh
        static void Main()
        {
            // thang 01-09, 10 11 12
            // ngay 01-09, 10-19, 20-29, 30-31
            var pattern = @"^(0[1-9]|[1-2][0-9]|3[0-1])/(0[1-9]|1[0-2])/\d{4}$";
            var regex = new Regex(pattern);
            Console.WriteLine("Nhap vao ngay sinh dang 25/05/2009: ");
            var birthDate = Console.ReadLine();
            if (regex.IsMatch(birthDate))
            {
                Console.WriteLine("Ngay sinh hop le.");
            }
            else
            {
                Console.WriteLine("Ngay sinh khong hop le.");
            }
        }
    }
}
