using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CSharpCourse
{
    class Lesson48
    {
        //So khớp mã sinh viên
        static void Main()
        {
            // DCCN|DCDT|DCVT|DCQT|DCDP|DCAT
            var pattern = @"^B\d{2}(DCCN|DCDT|DCVT|DCQT|DCDP|DCAT)\d{3}$";
            var regex = new Regex(pattern, RegexOptions.IgnoreCase);
            Console.WriteLine("Nhap ma sinh vien: ");
            var studentId = Console.ReadLine();
            if (regex.IsMatch(studentId))
            {
                Console.WriteLine("Ma sinh vien hop le.");
                Console.WriteLine(studentId.ToUpper()); //Cho thành viết hoa
            }
            else
            {
                Console.WriteLine("Ma sinh vien khong hop le.");
            }
        }
    }
}
