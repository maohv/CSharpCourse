using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse
{
    class Student : IComparable<Student>      //Kế thừa IComparable, thường đc sử dụng so sánh các đối tượng khi tiến hành sắp xếp
    {
        public string StudentId { get; set; }
        public string FullName { get; set; }
        public float Gpa { get; set; }

        public Student(string id, string fullName, float gpa)
        {
            StudentId = id;
            FullName = fullName;
            Gpa = gpa;
        }
        public override string ToString() => $"{StudentId}, {FullName}, {Gpa}";

        public int CompareTo(Student other) // triển khai phương thức IComparable
        {
            if(Gpa == other.Gpa)
            {
                return 0 ;
            }else if(Gpa < other.Gpa)
            {
                return -1 ;
            }
            else
            {
                return 1 ;
            }
        }
    }

    class Lesson39
    {
        //Interface
        static void Main()
        {
            Student[] students = new Student[]
            {
                new Student("SV1001", "Meo", 2.19f),
                new Student("SV1002", "Con", 3.79f),
                new Student("SV1003", "Lon", 3.69f),
                new Student("SV1004", "Ton", 3.59f),
                new Student("SV1005", "Hi", 3.39f),
                new Student("SV1006", "Hi", 3.19f),
            };
            Console.WriteLine("Truoc khi sap xep: ");
            ShowData(students);
            Console.WriteLine("====================");
            Console.WriteLine("Sau khi sap xep: ");
            Array.Sort(students); //sắp xếp theo điểm tăng dần
            Array.Reverse(students); //sắp xếp theo điểm giảm dần
            ShowData(students);
        }

        public static void ShowData(Student[] students)
        {
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }
    }
    public interface Icontrol
    {
        void Paint();
    }

    public interface ISurface
    {
        void Paint();
    }

    public class SampleClass : Icontrol, ISurface //kế thừa từ 2 interface
    {
        // 2 Paint triển khai tường minh
        void Icontrol.Paint()
        {
            Console.WriteLine("Icontrol.Paint");
        }

        void ISurface.Paint()
        {
            Console.WriteLine("ISurface.Paint");
        }

    }



    //class Lesson39
    //{
    //    //Interface
    //    static void Main()
    //    {
    //        SampleClass obj= new SampleClass();
    //        Icontrol control = obj;
    //        ISurface surface = obj;
    //        //obj.Paint(); lỗi error
    //        control.Paint(); //Kết quả: Icontrol.Paint
    //        surface.Paint(); //Kết quả: ISurface.Paint

    //        //============================================================

    //        //Circle circle = new Circle(3, 5, 12);
    //        //IShape iShape = new Circle(7, 4, 30); //Circle kế thừa từ Ishap, biến kiểu cha hoàn toàn có thể tham chiếu tới kiểu con
    //        //Console.WriteLine($"Chu vi duong r = {circle.Radius} : {circle.Perimeter()} ");
    //        //Console.WriteLine($"Dien tich duong tron r = {circle.Radius} : {circle.Area()} ");
    //        //Console.WriteLine($"Chu vi duong r = {((Circle)iShape).Radius} : {iShape.Perimeter()} "); //iShape ép kiểu sang circle
    //        //Console.WriteLine($"Dien tich duong tron r = {((Circle)iShape).Radius} : {iShape.Area()} ");

    //    }
    //}

    public interface IShape
    {   //Khai báo thuộc tính abstract
        int X { get; set; }
        int Y { get; set; }
        // Phương thức abstract
        double Area();
        double Perimeter();
    }
    class Circle : IShape
    {
        private int _x; //để trả về x hay y thì phải trường dữ liệu  tương ứng với x và y
        private int _y;

        public double Radius { get; set; }

        public int X { get => _x; set => _x = value; }
        public int Y { get => _y; set => _y = value; }
        public Circle(int x, int y, double radius)
        {
            X = x;
            Y = y;
            Radius = radius;
        }
        public double Area() => Math.PI * Radius * Radius;

        public double Perimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }

    interface IPoint
    {  //Khai báo abtract properties
        public int X { get; set; }
        int Y { get; set; }
        //Phương thúc tính khoảng cách giữa 2 điểm
        double Distance(IPoint other);
    }
}
