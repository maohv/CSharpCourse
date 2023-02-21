using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse
{
    class Lesson17
    {
        //Các đối số được đặt tên và đối số tùy chọn
        static void Main()
        {
            //var first = "Hoang";
            //var last = "Ngo";
            //var mid = "Minh";
            //var age = 20;
            //var gpa = 3.56f;

            ////Gọi theo cách truyền thống
            //ShowInfo(first,last,mid,age,gpa);
            //ShowInfo(firstName:first, lastName: last,midName: mid, age:age, gpa: gpa);
            //ShowInfo(age: age, gpa: gpa, firstName:first, lastName: last,midName: mid);
            //ShowInfo(first, last, midName:mid, age:age, gpa);

            //Cung cấp chỉ tham số bắt buộc
            ShowInfo("Hoang Mao");
            ShowInfo(fullName: "Hoang Mao");
            ShowInfo(fullName: "Hoang Mao", age: 21);
            ShowInfo("Hoang Mao", 21, "Da nang");
        }

        static void ShowInfo(string fullName, int age = 0, string address = "Ha Noi")
        {
            Console.WriteLine("Full name: " + fullName);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Address: " + address);

        }
        static void ShowInfo(string firstName, string lastName, string midName, int age, float gpa)
        {
            Console.WriteLine($"Firs Name: {firstName}");
            Console.WriteLine($"Last Name: {lastName}");
            Console.WriteLine($"Mid Name: {midName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"GPA: {gpa}");
            Console.WriteLine("========================");
        }
    }
}