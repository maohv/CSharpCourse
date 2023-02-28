using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Teacher
    {        
        public string Id { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public long Salary { get; set; }
        public Teacher(string id, string name, string address, long salary)
        {
            Id = id;
            FullName = name;
            Address = address;
            Salary = salary;
        }

        public override string ToString() => $"Teacher[{Id}, {FullName}, {Address}, {Salary}]";
    }
}
