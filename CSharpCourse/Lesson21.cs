using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse
{
    class Lesson21
    {
        //Mảng 1 chiều
        static void Main()
        {
            //Khởi tạo giá trị cho các phần tử mảng
            //float[] grades = {1.25f, 3,47f};
            //var values = new string[] { "hello","Helu"};

            ////Gán giá trị cho phần tử cụ thể
            //var friends = new string[200];
            //friends[0] = "Hoa";
            //friends[1] = "Mai";
            //friends[2] = "Dao";
            //friends[199] = "No";

            //for (int i = 0; i < friends.Length; i++)
            //{
            //    Console.WriteLine(friends[i]);
            //}

            //foreach (var item in friends)
            //{
            //    Console.WriteLine(item);
            //}


            var friends = FriendNames();
            ShowFriends(friends);
        }
        static string[] FriendNames()
        {
            Console.WriteLine("Nhap so luong nguoi ban: ");
            int n = int.Parse(Console.ReadLine());
            string[] friends = new string[n];
            for (int i = 0; i < friends.Length; i++)
            {
                Console.WriteLine("Nhap ten mot nguoi ban: ");
                friends[i] = Console.ReadLine();
            }
            return friends;
        }

        // phương thức hiển thị danh sách tên những người bạn
        static void ShowFriends(string[] friends)
        {
            Console.WriteLine("=====================");
            Console.WriteLine("So luong ban be: " + friends.Length);
            Console.WriteLine("Danh sach nhung nguoi ban cua toi: ");
            foreach (var item in friends)
            {
                Console.WriteLine(item);
            }
        }
    }
}