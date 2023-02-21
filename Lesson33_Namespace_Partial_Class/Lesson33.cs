using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson33_Namespace_Partial_Class
{
    partial class Student
    {
        public void GetInputInfo()
        {
            Console.WriteLine("Ma sinh vien: ");
            StudentId = Console.ReadLine();
            Console.WriteLine("Ho va ten: ");
            FullName = Console.ReadLine();
        }

        public void DoHomeWork(string subject)
        {
            Console.WriteLine($"Sinh vien {FullName} dang lam bai tap mon {subject}");
        }

        public void PayFee(long amout)
        {
            Console.WriteLine($"Sinh vien {FullName} nop tien hoc phi {amout}k");
        }
        public void ShowInfo()
        {
            Console.WriteLine("Ma sinh vien: " + StudentId);
            Console.WriteLine("Ho va ten: " + FullName);

        }
    }

}