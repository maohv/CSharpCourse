using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CSharpCourse
{
    class Lesson45
    {
        //Tổng quan về Regular expression
        static void Main()
        {
            var input = "Xin Chao  toi chang   can  choi voi   ban dau";
            var pattern = @"\s+"; //bắt đầu bằng @, sau đó là chuỗi, tìm dấu cách bằng \s, một hoặc chiều dấu cách dùng +
            var regex = new Regex(pattern);
            var words = regex.Split(input);
            //In ra kết quả
            foreach (var item in words)
            {
                Console.WriteLine(item);
            }

            var result = regex.Replace(input, " ");//Thay thế chuỗi kí tự chỗ có nhiều dấu cách bằng 1 dấu cách
            Console.WriteLine("==> sau khi thay the: ");
            Console.WriteLine(result);
        }
    }
}
