using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse
{
    class Lesson62
    {
        //Tìm hiểu về delegate

        public delegate void MyDelegate(string msg);
        public delegate int CalculateDelegate(int a, int b);
        public delegate T FindMaxDelegate<T>(List<T> list);
        public static void ShowMessage(string msg)
        {
            Console.WriteLine(msg);
        }

        public static int Add(int a, int b) => a + b;
        public static int Sub(int a, int b) => a - b;
        public static int Mul(int a, int b) => a * b;

        public static void ShowResult(int a, int b, string op, CalculateDelegate cacl)
        {
            Console.WriteLine($"{a} {op} {b} = {cacl(a, b)}");
        }

        public static void PrintResultA(string msg)
        {
            Console.WriteLine($"{msg} thực hiện trong phương thức A");
        } 
        public static void PrintResultB(string msg)
        {
            Console.WriteLine($"{msg} thực hiện trong phương thức B");
        } 
        public static void PrintResultC(string msg)
        {
            Console.WriteLine($"{msg} thực hiện trong phương thức C");
        }

        static void Main()
        {
            Console.OutputEncoding= Encoding.UTF8;
            //MyDelegate print = ShowMessage;
            //print("Hello"); //gọi phương thức qua biến dalegate
            //print.Invoke("Hiiii"); //gọi qua phương thức Invoke

            //MyDelegate del = delegate (string msg)
            //{
            //    var upperCaseStr = msg.ToUpper();
            //    Console.WriteLine(upperCaseStr);
            //};
            //del("Test");

            //CalculateDelegate addDelegate = (a, b) => a + b;
            //var sum = addDelegate(20, 500);
            //Console.WriteLine(sum);
            int a = 200;
            int b = 300;
            ShowResult(a, b, "+", Add);
            ShowResult(a, b, "-", Sub);
            ShowResult(a, b, "*", Mul);
            //CalculateDelegate cacl = Add;
            //Console.WriteLine($"{a} + {b} = {cacl(a, b)}");
            //cacl = Sub;
            //Console.WriteLine($"{a} - {b} = {cacl(a, b)}");
            //cacl = Mul;
            //Console.WriteLine($"{a} * {b} = {cacl(a, b)}");

            //MyDelegate del = PrintResultA;
            //del += PrintResultB;
            //del += PrintResultC;
            //del("Learn C#");

            //đếm số lượng từ trong 1 câu
            Func<string, int> CountWordFunc = (str) =>
            {
                var data = str.Split(' ');
                return data.Length;
            };

            //Hiển thị xâu kí tự mà nó nhận được
            Action<string> printMessage = mesage => Console.WriteLine(mesage);

            //Kiểm tra xem các kí tự của câu có phải chữ hoa hay không ?

            Predicate<string> checkUpperCase = str => str.CompareTo(str.ToUpper()) == 0;

            var msg = "Test đếm từ !";
            var numOfWord = CountWordFunc.Invoke(msg);
            Console.WriteLine($"Số từ trong câu: \"{msg}\" là {numOfWord}");
            Console.WriteLine($"\"{msg}\" chỉ chứa các chữ cái hoa? {checkUpperCase(msg)}");
            Console.Write($"Thông điệp cần hiển thị là: ");
            printMessage.Invoke(msg);
        }
    }
}
