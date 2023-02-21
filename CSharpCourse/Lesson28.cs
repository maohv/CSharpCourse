using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse
{
    struct Point
    {
        public Point(int x, int y, string label)
        {
            this.x = x; //tránh trường hợp trùng tên sử dụng this
            this.y = y;
            this.label = label;
        }
        public int x;
        public int y;
        public string label;

        public override string ToString()
        {
            return $"{label} ({x}), {y})";
        }
    }

    struct Triagle
    {
        public Triagle(Point a, Point b, Point c)
        {
            A = a;
            B = b;
            C = c;
        }
        public Point A { get; set; }
        public Point B { get; set; }
        public Point C { get; set; }

        public override string ToString() => $"Triagle ({A}, {B}, {C})";
    }
    class Lesson28
    {
        struct Rectangle
        {
            public Rectangle(int x, int y)
            {
                X = x;
                Y = y;
            }
            public Rectangle(int x, int y, int width, int height)
            {
                X = x;
                Y = y;
                Width = width;
                Height = height;
            }
            public int X { get; set; } = 0;
            public int Y { get; set; } = 0;
            public int Width { get; set; } = 20;
            public int Height { get; set; } = 20;

        }

        //Kiểu dữ liệu struct
        static void Main()
        {
            //Rectangle rect = new Rectangle(10, 25);
            //Console.WriteLine(rect.Width);
            //Console.WriteLine(rect.Height);

            Point p1 = new Point(1, 2, "A");
            Point p2 = new Point(5, 3, "B");
            Point p3 = new Point(8, 6, "C");
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Triagle triagle = new Triagle(p1, p2, p3);
            Console.WriteLine(triagle);
        }
    }
}