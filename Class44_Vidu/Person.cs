using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class44_Vidu
{
    public class Person
    {
        public FullName FullName { get; set; }
        public Address Address { get; set; }
        public int Age { get; set; }
        public Person()
        {
            FullName = null;
            Address = null;
            Age = 0;
        }
        public Person(FullName fullName, Address address, int age)
        {
            FullName = fullName;
            Address = address;
            Age = age;
        }
        public override string ToString() => $"FullName = {FullName}" + $"\nAddress = {Address}" + $"\nAge = {Age}";


    }
    public class Student : Person
    {
        public string StudentId { get; set; }
        public float Gpa { get; set; }
        public string Major { get; set; }
        public Student()
        {
            StudentId = null;
            Gpa = 0;
            Major = null;
        }
        public Student(string studentId, float gpa, string major) : base(null, null, 0)
        {
            StudentId = studentId;
            Gpa = gpa;
            Major = major;
        }
        public override string ToString()
        {
            string info = base.ToString();
            info += $"StudentId = {StudentId}" +
                    $"Major = {Major}" +
                    $"Gpa = {Gpa}";
            return info;
        }
    }
    public class GraduatedStudent : Student, ISalaryCaculator
    {
        public long Salary { get; set; }
        public int GraduatedYear { get; set; }
        public long ReceivedSalary { get; set; }
        public GraduatedStudent()
        {
            Salary = 0;
            GraduatedYear = 0;
        }
        public GraduatedStudent(long salary, int year)
        {
            Salary = salary;
            GraduatedYear = year;
        }
        public void CalculateSalary(int numOfworkingDay)
        {
            ReceivedSalary = numOfworkingDay * Salary / 22;
        }
    }
    public class Address
    {
        public string Wards { get; set; }
        public string City { get; set; }
        public string District { get; set; }

        public Address(string wards, string district, string city)
        {
            Wards = wards;
            City = city;
            District = district;
        }
        public override string ToString() => $"{Wards}--{District}--{City}";

    }
    public class FullName
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MidName { get; set; }

        public FullName(string first, string last, string mid)
        {
            FirstName = first;
            LastName = last;
            MidName = mid;
        }
        public override string ToString() => $"{LastName} {MidName} {FirstName}";

    }
}
