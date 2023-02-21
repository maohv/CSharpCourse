using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse
{
    class Lesson36
    {
        //Tính chất kế thừa
        static void Main()
        {
            Student student = new Student("SV1001", 3.55f, "CNTT");
            Student student1 = new Student("SV1001", 3.66f, "CNTT");
            Console.WriteLine(student1.Equals(student));

            //student.FirstName = "Meo"; //Có thể truy cập thành phần kế thừa từ lớp cha
            //student.LastName = "Con";
            //student.MidName = "Leu Leu";
            //student.Age = 10;
            //Console.WriteLine($"Ho va ten: {student.FirstName} {student.LastName} {student.MidName}");
            ////truy cập tới các thành phần riêng của lớp con
            //Console.WriteLine($"Ma sinh vien: {student.StudentId}");
            //Console.WriteLine($"Diem Trung Binh: {student.Gpa}");

            /*=======================================================*/

            //Circle circle = new Circle();
            //circle.Radius = 20;
            //Console.WriteLine("Chu vi: " + circle.Perimeter());
            //Console.WriteLine("Dien tich duong tron: " + circle.Area());

            /*=======================================================*/


        }
    }

    class Shape
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string Name { get; set; }

        public virtual double Area()
        {
            return 0;
        }
        public virtual double Perimeter()
        {
            return 0;
        }
    }
    class Circle : Shape
    {
        public double Radius { get; set; }

        public override double Area()
        {
            return Math.PI * Radius * Radius; //Tính diện tích hình tròn
        }
        public override double Perimeter()
        {
            return Math.PI * Radius * 2; //Tính chu vi hình tròn
        }
    }
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double Area()
        {
            return Width * Height; //tính diện tích hình chữ nhật
        }
        public override double Perimeter()
        {
            return 2 * (Width + Height); //Tính chu vi hình chữ nhật
        }
    }



    class Father
    {
        public virtual void DoSomething(string somthing)
        {

        }
    }
    class Child : Father
    {
        public override void DoSomething(string something) //muốn override phải virtual ở lớp cha
        {

        }
    }
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MidName { get; set; }
        public int Age { get; set; }
        public Person() //constructor
        {

        }

        public void Sleep()
        {

        }
    }
    class Student : Person //Kế thừa lớp cha Person
    {
        public string StudentId { get; set; }
        public float Gpa { get; set; }
        public string Major { get; set; }

        public Student()
        {

        }
        public Student(string id, float gpa, string major)
        {
            StudentId = id;
            Gpa = gpa;
            Major = major;
        }
        public void DoHomeWork(string subject) //student có thể có bài tập về nhà
        {

        }

        public void DoExam(string subject) //có thể có bài kiểm tra
        {

        }

        public override bool Equals(object obj) //Nếu 2 đối tượng cùng mã sinh viên, coi 2 sinh viên là 1 đối tượng thì trùng mã sv thì override equals
        {
            if(obj.GetType() != this.GetType()) //Khác kiểu return false
            {
                return false;
            }
            var other = (Student)obj; //K khác kiểu thì chắc chắn cùng kiểu student, ép obj sang student
            return other.StudentId.CompareTo(StudentId) == 0; //Nếu như mã sv đc truyền vào và mã sv hiện tại = 0 thì nó là 1
        }

        public override int GetHashCode() //Equals sẽ có GetHashCode
        {
            return base.GetHashCode();
        }

        //Biểu diễn trường dữ liệu, thuộc tính của kiểu dữ liệu nó override
        public override string ToString() => $"Student: [Student={StudentId}, Gpa={Gpa}, Major={Major}]";
    }

    //Không cho phép kế thừa thêm sealed vào class ^^
}
