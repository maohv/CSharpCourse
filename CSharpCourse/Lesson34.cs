using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse
{
    class Class34
    {
        //Các kiểu lồng nhau
        static void Main()
        {
            //Student student = new Student();
            //Console.WriteLine("Ho va ten: ");
            //student.Name = Console.ReadLine();
            //Console.WriteLine("Full name: " + student.Name);
            //Console.WriteLine("First name: "+ student.FirstName);

            //tạo đối tượng của inner class từ bên ngoài
            OuterClass.InnerClass innerObject = new OuterClass.InnerClass();
            Console.WriteLine("Nhap vao message: ");
            innerObject.Message = Console.ReadLine();
            Console.WriteLine("Messagge from inner class: ");
            innerObject.ShowMessage();
        }
    }

    class OuterClass
    {
        public class InnerClass
        {
            public string Message { get; set; }

            public void ShowMessage()
            {
                Console.WriteLine(Message);
            }
        }
    }
    class Student
    {
        private FullName _fullName;

        public string Name
        {
            get => _fullName.ToString();

            set
            {
                var data = value.Split(' ');
                _fullName.FirstName = data[data.Length - 1]; ;
                _fullName.LastName = data[0];
                var mid = "";
                for (int i = 0; i < data.Length - 1; i++)
                {
                    mid += data[i] + "";
                }
                _fullName.MidName = mid.TrimEnd();
            }
        }

        public string FirstName { get => _fullName.FirstName; }

        public Student()
        {
            _fullName = new FullName("", "", "");
        }

        class FullName //Mặc định nếu không có access modifier thì inner class sẽ là private.
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string MidName { get; set; }



            public FullName(string first, string mid, string last)
            {
                FirstName = first;
                LastName = last;
                MidName = mid;
            }

            public override string ToString() => $"{FirstName} {MidName} {LastName}";

        }

        private class Address
        {
            public string Wards { get; set; }
            public string District { get; set; }
            public int City { get; set; }
        }

    }

    
}