using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse
{
    class Lesson3
    {
        static void Main()
        {  //Nhập vào chuyển đổi dữ liệu
            Console.WriteLine("Nhap tuoi:");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Ho Va Ten:");
            string fullname = Console.ReadLine();
            Console.WriteLine("Diem Trung Binh:");
            float gpa = float.Parse(Console.ReadLine());
            //Hiển thị ra màn hình

            Console.WriteLine($"Ho va ten: {fullname}");
            Console.WriteLine($"Tuoi: {age}");
            Console.WriteLine($"Diem trung binh: {gpa}");
        }
    }
}