using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console; //viết nhanh khi import class console
namespace CSharpCourse
{
    class Lesson31
    {
        //Các thành phần static
        static void Main()
        {
            //int sum = Add(1, 2, 3);
            //WriteLine("Tong :" + sum);

            WriteLine("Gia tri mac dinh cua AutoIncrementId: " + Employee.AutoIncrementId);
            Employee emp1 = new Employee("Zin1", 120000);
            Employee emp2 = new Employee("Zin2", 130000);
            Employee emp3 = new Employee("Zin3", 140000);
            WriteLine("Gia tri thay doi cua AutoIncrementId: " + Employee.AutoIncrementId);
        }

        static int Add(int a, int b, int c)
        {
            return a + b + c;
        }
    }
    class Employee
    {
        static Employee() //static constructor
        {
            fine = 100000; //100k
            AutoIncrementId = 10000; //mã nhân viên bắt đầu 10000
        }

        //instance constructor
        public Employee(string fullName, long salaty)
        {
            EmpId = AutoIncrementId++;
            FullName = fullName;
            Salary = salaty;
        }

        public static int AutoIncrementId { get; set; } //mã nhân viên tự tăng

        public static long fine; //tiền phạt
        public int EmpId { get; set; }
        public string FullName { get; set; }
        public long Salary { get; set; }
    }
}