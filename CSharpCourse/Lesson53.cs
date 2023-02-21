using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CSharpCourse
{
    class Lesson53
    {
        //Ngoại lệ do người dùng tự định nghĩa
        static void Main()
        {
            try // chứa đoạn code có thể xảy ra ngoại lệ
            {
                var fullName = GetFullName();
                Console.WriteLine($"Xin chao {fullName}!");
            }
            catch (InvalidNameException ex) // bắt và xử lý ngoại lệ xảy ra trong khối try
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex);
            }
        }

        static string GetFullName()
        {
            // họ tên chỉ được phép chứa chữ cái, dấu cách có từ 2-40 kí tự
            var pattern = @"^[\p{L} ]{2,40}$";
            Console.WriteLine("Ho va ten: ");
            var fullName = Console.ReadLine();
            var regex = new Regex(pattern);
            if (regex.IsMatch(fullName))
            {
                return fullName;
            }
            else
            {   // văng ngoại lệ họ tên không hợp lệ
                throw new InvalidNameException("Ho va ten khong hop le.", fullName);
            }
        }
    }

    // lớp ngoại lệ mô tả lỗi họ và tên không hợp lệ
    class InvalidNameException : Exception
    {
        public string InvalidName { get; set; } // thuộc tính
        // các constructor
        public InvalidNameException() : base() { }
        public InvalidNameException(string message) : base(message) { }
        public InvalidNameException(string message, Exception innerException)
            : base(message, innerException) { }
        public InvalidNameException(string message, string invalidName) : base(message)
        {
            InvalidName = invalidName;
        }

        // phương thức ghi đè của lớp Object
        public override string ToString()
        {
            return base.ToString() + $"\nInvalidName: {InvalidName}";
        }
    }
}
