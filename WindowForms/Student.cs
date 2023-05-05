using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowForms
{
    public class Student
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public string Major { get; set; }
        public DateTime BirthDate { get; set; }
        public float Gpa { get; set; }

        public Student(string id, string fullName, string major, DateTime birthDate, float gpa)
        {
            Id = id;
            FullName = fullName;
            Major = major;
            BirthDate = birthDate;
            Gpa = gpa;
        }
        public object[] ToPropertiesArray()
        {
            return new object[] { Id, FullName, BirthDate.ToString("dd/MM/yyy"), Major, Gpa };
        } 
    }
}
