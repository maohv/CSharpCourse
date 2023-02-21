using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson33_Namespace_Partial_Class
{
    internal class Program
    {

    }
    partial class Student //cho phép lớp class sau sửa dụng triển khai lớp đã có thì thêm partial
    {
        public string StudentId { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public string Major { get; set; }
        public float Gpa { get; set; }

        public Student() : this("")
        {
        }

        public Student(string id) : this(id, "")
        {
        }

        public Student(string id, string fullName) : this(id, fullName, 0, "", 0)
        {
        }

        public Student(string id, string fullName, int age, string major, float gpa)
        {
            StudentId = id;
            FullName = fullName;
            Age = age;
            Major = major;
            Gpa = gpa;
        }
    }


}