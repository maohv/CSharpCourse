using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse
{
    //Cấu trúc switch
    class Lesson9
    {
        static void Main()
        {
            // Các ví dụ: 

            //int dayOfWeek = int.Parse(Console.ReadLine());
            //switch (dayOfWeek)
            //{
            //    case 1:
            //        Console.WriteLine("Monday");
            //        break;
            //    case 2:
            //        Console.WriteLine("Tuesday");
            //        break;
            //    case 3:
            //        Console.WriteLine("Wednesday");
            //        break;
            //    case 4:
            //        Console.WriteLine("Thursday");
            //        break;
            //    case 5:
            //        Console.WriteLine("Friday");
            //        break;
            //    case 6:
            //        Console.WriteLine("Saturday");
            //        break;
            //    case 7:
            //        Console.WriteLine("Sunday");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid day of week. Please try again!");
            //        break;
            //}

            /* --------------------------------------------------*/


            //double gpa = 3.25;
            //string rank;
            //switch (gpa)
            //{
            //    case < 1.6 and >= 0.0: // gpa từ 0.0 đến 1.6: trượt môn, F
            //        rank = "F";
            //        break;
            //    case < 2.0 and >= 1.6: // gpa từ 1.6 đến dưới 2.0, điểm D
            //        rank = "D";
            //        break;
            //    case >= 2.0 and < 2.8: // gpa từ 2.0 đến dưới 2.8, điểm C
            //        rank = "C";
            //        break;
            //    case >= 2.8 and < 3.2: // gpa từ 2.8 đến dưới 3.2, điểm B
            //        rank = "B";
            //        break;
            //    case >= 3.2 and < 3.6: // gpa từ 3.2 đến dưới 3.6, điểm A
            //        rank = "A";
            //        break;
            //    case >= 3.6 and <= 4.0: // gpa từ 3.6 đến 4.0, điểm A+
            //        rank = "A+";
            //        break;
            //    default:
            //        rank = "";
            //        Console.WriteLine("Wrong GPA. Please try again!");
            //        break;
            //}
            //Console.WriteLine($"GPA = {gpa}, rank = {rank}");

            string input = Console.ReadLine();
            var data = input.Split(' ');
            float a = float.Parse(data[0]); // lấy số a
            float b = float.Parse(data[2]); // lấy số b
            string op = data[1]; // lấy phép toán
            switch (op)
            {
                case "+":
                    Console.WriteLine($"{a} + {b} = {a + b} ");
                    break;
                case "-":
                    Console.WriteLine($"{a} - {b} = {a - b} ");
                    break;
                case "*":
                    Console.WriteLine($"{a} * {b} = {a * b} ");
                    break;
                case "/":
                    if (b == 0)
                    {
                        Console.WriteLine("ERROR");
                    }
                    else
                    {
                        Console.WriteLine($"{a} / {b} = {a / b} ");
                    }
                    break;
                default:
                    Console.WriteLine("ERROR");
                    break;
            }
        }
    }
}