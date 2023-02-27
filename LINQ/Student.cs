using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class Student
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public Student(string id, string fullName, string address)
        {
            Id = id;
            FullName = fullName;
            Address = address;
        }
        public override string ToString() => $"Student[{Id}, {FullName}, {Address}]";
    }
}
