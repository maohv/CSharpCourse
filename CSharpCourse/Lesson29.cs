using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse
{
    class Lesson29
    {
        //Tổng quan lớp và đối tượng
        static void Main()
        {
            //Student studen1 = new Student("SV101");
            //Console.WriteLine($"Ma sinh vien: {studen1.Id}");
            //Console.WriteLine($"Ho ten: {studen1.FullName}");

            //Tạo ra đối tượng của bank account
            BankAccount acc = new BankAccount();
            Console.WriteLine($"Acc id: {acc.AccId}");
            Console.WriteLine($"Acc Number: {acc.AcNumber}");
        }

        class Student
        {
            //phương thức khởi tạo
            public Student(string id)
            {
                Id = id;

            }

            public Student(string id, string fullName, int age)
            {
                Id = id;
                FullName = fullName;
                Age = age;
            }
            //các thuộc tính
            public string Id { get; set; }
            public string FullName { get; set; } = "No Name";
            public int Age { get; set; }
            public float Gpa { get; set; }
            public string Major { get; set; } = "CNTT";
            //trường
            public string rank = "Truot Mon";

            public void CaculateRank()
            {
                //statements
            }
        }

        class BankAccount
        {
            public int AccId { get; set; }
            public string AcNumber { get; set; }
            public string Owner { get; set; }
            public long Balance { get; set; }
            public string BankName { get; set; }

            // nạp tiền vào tk
            public long Deposit(long amout)
            {
                if (amout > 0)
                {
                    Balance += amout;
                    return amout;
                }
                return 0;
            }
            // chuyển tiền
            public long BankTransfer(BankAccount other, long amount)
            {
                if (other != null && amount < Balance)
                {
                    other.Balance += amount;
                    Balance -= amount;
                    return amount;
                }
                return 0;
            }

            //rút tiền
            //kiểm tra số dư...
        }
    }
}