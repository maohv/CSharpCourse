using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse
{
    //Tính đóng gói dữ liệu
    class Lesson32
    {
        static void Main()
        {
            //Student student = new Student("SV1001", "Meo", 20, 3.25f);
            // student._id = "SV1003"; k thể truy cập từ bên ngoài lớp của nó

            Point point = new Point(3, 5);
            Console.WriteLine(point);
        }
    }

    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString() => $"Point({X} {Y})";

    }

    class BankCard
    {
        private string _cardType;
        public int Id { get; private set; } //k cho gán giá trị từ bên ngoài, chỉ cho đọc
        public string CardNumber { get; } //Nếu  muốn chỉ đọc số thẻ bỏ set
        public string CardType { set => _cardType = value; } //Nếu muốn chỉ ghi thì chỉ rõ chỉ ghi gì
    }

    class Student
    {
        private string _id;
        private string _fullName;
        private int _age;


        public Student(string id, string fullName, int age, float gpa)
        {
            _id = id;
            _fullName = fullName;
            _age = age;
        }

        public string GetId() => _id; //phương thức get cho thằng id

        public void SetId(string id) => _id = id; //phương thức set

        public string GetFullName() => _fullName;

        public void SetFullName(string fullName)
        {
            _fullName = fullName;
        }

        //public int Age //thông thường property sẽ như này
        //{
        //    get => _age;

        //    set
        //    {
        //        if (value > 0)
        //        {
        //            _age = value;
        //        }
        //        else
        //        {
        //            Console.WriteLine("Tuoi k hop le");
        //            _age = 0;
        //        }
        //    }
        //}
        public int Age //hoặc như này
        {
            get => _age;
            set => _age = value;
        }

        //và sẽ gói gọn bằng auto property
        public float Gpa { get; set; } = 1.0f; //Nếu k có gì khởi tạo điểm Tb = 1.0f
    }
}