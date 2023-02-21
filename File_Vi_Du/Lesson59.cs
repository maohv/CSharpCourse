using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace File_Vi_Du
{
    class Lesson59
    {
        //Đọc ghi file JSON
        static void Main()
        {
            //var data = File.ReadAllText("data.json"); //đọc toàn bộ file data.json trong thư mục debug
            //var jObject = JObject.Parse(data);
            //var jArray = jObject["students"]; //tùy chọn đọc ra dữ liệu của phần name là students, phải trùng với đối tượng students file data.json
            //List<Student> students = new List<Student>();
            //foreach (var item in jArray)
            //{
            //    students.Add(item.ToObject<Student>());
            //}
            //ShowData(students);

            //========================================
            Console.OutputEncoding = Encoding.UTF8;
            var root = new
            {
                students = CreateStudents()
            };
            var strJson = JsonConvert.SerializeObject(root, Formatting.Indented);
            Console.WriteLine(strJson);
            File.WriteAllText("data1.json", strJson);
        }

        static void ShowData(List<Student> people)
        {
            Console.OutputEncoding = Encoding.UTF8;
            foreach (var item in people)
            {
                Console.WriteLine(item);
            }
        }

        //Thêm dữ liệu vào file json
        static Student[] CreateStudents()
        {
            return new Student[] {
                new Student("SV101", 20, "CNTT", 3.25f,
                    new FullName("Hoàng", "Nguyễn", "Đình"),
                    new Address("Trung Hòa", "Cầu Giấy", "Hà Nội")),
                new Student("SV102", 21, "CNTT", 3.45f,
                    new FullName("Lâm", "Văn", "Tiến"),
                    new Address("Nghĩa Đô", "Cầu Giấy", "Hà Nội")),
                new Student("SV103", 24, "CNTT", 3.75f,
                    new FullName("Mạnh", "Lưu", "Thế"),
                    new Address("Dịch Vọng", "Cầu Giấy", "Hà Nội")),
                new Student("SV104", 21, "CNTT", 3.15f,
                    new FullName("Bình", "Lưu", "Đức"),
                    new Address("Mai Dịch", "Cầu Giấy", "Hà Nội")),
                new Student("SV105", 20, "CNTT", 3.15f,
                    new FullName("Mai", "Đinh", "Thị"),
                    new Address("Quan Hoa", "Cầu Giấy", "Hà Nội"))
            };
        }
    }
    class Student // lớp mô tả thông tin sinh viên
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("age")]
        public int Age { get; set; }
        [JsonProperty("major")]
        public string Major { get; set; }
        [JsonProperty("gpa")]
        public float Gpa { get; set; }
        [JsonProperty("fullname")]
        public FullName FullName { get; set; }
        [JsonProperty("address")]
        public Address Address { get; set; }

        public Student() { }
        public Student(string id, int age, string major,
            float gpa, FullName fullName, Address address)
        {
            Id = id;
            Address = address;
            FullName = fullName;
            Age = age;
            Major = major;
            Gpa = gpa;
        }

        public override string ToString()
        {
            return $"Student[Id = {Id}, Age = {Age}, Major = {Major}, " +
                $"Gpa = {Gpa}, FullName = {FullName}, Address = {Address}]";
        }
    }

    internal class FullName
    {
        [JsonProperty("first")]
        public string FirstName { get; set; }
        [JsonProperty("last")]
        public string LastName { get; set; }
        [JsonProperty("mid")]
        public string MidName { get; set; }

        public FullName() { }

        public FullName(string first, string last, string mid)
        {
            FirstName = first;
            LastName = last;
            MidName = mid;
        }

        public override string ToString()
        {
            return $"{LastName} {MidName} {FirstName}";
        }
    }

    internal class Address
    {
        [JsonProperty("wards")]
        public string Wards { get; set; }
        [JsonProperty("district")]
        public string District { get; set; }
        [JsonProperty("city")]
        public string City { get; set; }


        public Address() { }
        public Address(string ward, string district, string city)
        {
            Wards = ward;
            District = district;
            City = city;
        }

        public override string ToString()
        {
            return $"{Wards} - {District} - {City}";
        }
    }
}
