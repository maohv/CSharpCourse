using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse
{
    class Lesson30
    {
        //Phương thức khởi tạo
        static void Main()
        {

        }

    }
    class PerSon
    {
        public PerSon() : this("")
        {

        }

        public PerSon(string first) : this(first, "") //gọi tới thằng có 1 tham số, thằng 1 tham số gọi tới 2 tham số, 2 tham số gọi tới 3 tham số
        {
            FirstName = first;
        }

        public PerSon(string frist, string last) : this(frist, last, 0) // gọi tới đối tượng contrucstor dài nhất
        {

        }

        public PerSon(string fist, string last, int age)
        {
            FirstName = fist;
            LastName = last;
            Age = age;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
}