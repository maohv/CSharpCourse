using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse
{
    class Lesson37
    {
        //Mối quan hệ thành phần has-a

    }

    class FullName
    {
        //...
    }

    class Subject
    {

    }
    class Student
    {
        //Aggregation
        public string[] PhoneNumbers;
        public int Age { get; set; }

        public FullName FullName { get; set; } // Composition quan hệ thành phần chặt
        public Student(FullName fullName)
        {
            FullName = fullName;
        }
        public void DoExam(Subject subject) //Association
        {
            ///....
        }
    }
}
