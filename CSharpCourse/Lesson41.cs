using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CSharpCourse
{
    class BaseClass
    {
        public string Name { get; set; }
        protected long Salary { get; set; } //protected có thể nhìn thấy trong lớp con

        public virtual void DoSomething()
        {
            Console.WriteLine("DoSomething in BaseClass.");
        }
    }
    class DerivedClass : BaseClass
    {
        public new string Name { get; set; } //Muốn ẩn các thành phần trên lớp cha, thêm new trước kiểu trả về
        public new long Salary { get; set; }

        public new void DoSomething()
        {
            Console.WriteLine("DoSomething in DerivedClass");
        }
    }

    class A
    {
        public virtual void DoSomething()
        {
            Console.WriteLine("DoSomething in class A");
        }
    }
    class B : A
    {
        public sealed override void DoSomething() //K cho thằng nào sau thằng B này override sử dụng sealed
        {
            Console.WriteLine("DoSomething in class B");
        }
    }
    class C : B
    {
        //public new void DoSomething()
        //{
        //    Console.WriteLine("DoSomething in class C");
        //}
    }
    class Lesson41
    {
        static void Main()
        {
            //    DerivedClass derived = new DerivedClass();
            //    derived.DoSomething();
            //    BaseClass baseObj = derived; //cho đối tượng của lớp cha, tham chiếu tới lớp con thì nó k thể hiện tính đa hình vì new mới nên sẽ bị ẩn thành phần lớp cha 
            //    baseObj.DoSomething();

            //===================================================

            C c = new C();
            c.DoSomething();
            A a = c;
            a.DoSomething();
        }

        //static void Main()
        //{
        //    //Tính chất đa hình
        //    Shape[] shapes = new Shape[]
        //    {
        //        new Circle(20),
        //        new Triagle(20,30,40),
        //        new Rectangle(4,6)
        //    };
        //    ShowResult(shapes);

        //}
        //static void ShowResult(Shape[] shapes)
        //{
        //    foreach (var item in shapes)
        //    {
        //        Console.WriteLine(item);
        //        Console.WriteLine(item.Perimeter());
        //        Console.WriteLine("==========================");
        //    }
        //}

    }

    class Shape
    {
        public int X { get; set; }
        public int Y { get; set; }

        //phương thức vitrual
        public virtual double Perimeter() => 0;
    }
    class Triagle : Shape
    {
        public double EdgeA { get; set; }
        public double EdgeB { get; set; }
        public double EdgeC { get; set; }
        public Triagle(double a, double b, double c)
        {
            EdgeA = a;
            EdgeB = b;
            EdgeC = c;
        }
        //ghi đè phương thúc Perimeter của Shape
        public override double Perimeter() => EdgeA + EdgeB + EdgeC;
        public override string ToString() => $"Triagle: [EdgeA ={EdgeA}, [EdgeB ={EdgeB}, [EdgeA ={EdgeB} ]";

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
        public override double Perimeter() => 2 * (Width + Height);
        public override string ToString() => $"Rectangle: [Width ={Width}, [Height ={Height}]";
    }
    class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle(double radius)
        {
            Radius = radius;
        }
        public override double Perimeter() => 2 * Math.PI * Radius;
        public override string ToString() => $"Circle: [Radius ={Radius}]";
    }
}
