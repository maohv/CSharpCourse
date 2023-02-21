using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse
{
    class Lesson22
    {
        //Mảng 2 chiều
        static void Main()
        {
            //int row = 5;
            //int col = 4;

            ////Khai báo mảng hình chữ nhật

            //int[,] matrix = new int[3,4];
            //var friends = new string[row, col];

            ////Khai báo mảng răng cưa

            //var jaggerdArr1 = new int[row][];
            //int[][] jaggerdArr2 = new int[row][];
            //for (int i = 0; i < row; i++)
            //{
            //    jaggerdArr1[i] = new int[i + 1];
            //    jaggerdArr2[i] = new int[i + 5];
            //}

            //Khởi tạo

            //int[,] matrix = new int[,]
            //{
            //    {1, 2, 3, 4 },
            //    {5, 6, 7, 8},
            //    {0, 5, 9, 7}
            //};
            //Console.WriteLine(matrix.Length); //Hiển thị theo chiều dọc
            //var friends = new string[,]
            //{
            //    {"Hoa", "Mai", "Dao", "No" },
            //    {"Khoe", "Sac", "Mua", "Xuan" },
            //    {"That", "La", "Dep", "Qua" },              
            //};
            //Console.WriteLine(friends[1,2]);

            //Mảng răng cưa
            int[][] jaggedArr = new int[][]
            {
                new int[]{1, 2, 3},
                new int[]{4, 5, 6, 7},
                new int[]{2, 5},
            };

            for (int row = 0; row < jaggedArr.Length; row++)
            {
                for (int col = 0; col < jaggedArr[row].Length; col++)
                {
                    Console.Write(jaggedArr[row][col] + " ");
                }
                Console.WriteLine();
            }


            int[,] matrix = new int[,]
            {
                {1, 2, 3, 4},
                {5, 6, 7, 8},
                {0, 5, 9, 7}
            };
            //duyệt mảng
            Console.WriteLine($"So luong phan tu trong matrix: {matrix.Length}");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = matrix.GetLength(1) - 1; j >= 0; j--) //đảo ngược phần tử trong hàng
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Duyet mang voi foreach: ");
            foreach (var item in matrix)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}