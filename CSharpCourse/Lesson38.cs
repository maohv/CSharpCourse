using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse
{

    public abstract class Poin
    {
        protected int _x;
        protected int _y;
        // các accessor abstract

        public abstract int X { get; }
        public abstract int Y { get; }
        public abstract void DoSomething();
    } 

    class DerivedPoint : Poin //Nếu k muốn trở thành lớp abstract phải triển khai hết thành phần.
    {
        public override int X { get => _x + 10; }
        public override int Y { get => _y + 10; }

        public override void DoSomething()
        {
           //...

        }
    }

    class Lesson38
    {
        //Lớp trừu tượng
        static void Main()
        {
            // Point poin = new Point(); lớp abstract k thể tạo đối tượng
            Rectangle rect = new Rectangle(20,30);
            Console.WriteLine($"Dien tich hinh chu nhat {rect.Area()}");

        }
    }

    abstract class Shape
    {
        public int X { get; set; }
        public int Y { get; set; }

        public abstract double Area();

    }

    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double Area() => Width * Height;
     
    }
}
