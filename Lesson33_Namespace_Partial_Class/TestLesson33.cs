using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson33_Namespace_Partial_Class
{
    class TestLesson33
    {
        public static void Main()
        {
            Student student = new Student();
            student.GetInputInfo();
            student.PayFee(2000);
            Console.WriteLine("=========================");
            student.ShowInfo();
        }
    }
}