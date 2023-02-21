using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse
{
    class Lesson60
    {
        //Phương thức generic và lớp generic
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Pair<string, string> hello = new Pair<string, string>("Hello","Xin Chào");
            //Pair<string, string> lovely = new Pair<string, string>("Lovely","Đáng yêu");
            //Console.WriteLine($"Từ tiếng anh: {hello.Key} => Nghĩa tiếng việt: {hello.Value}");
            //Console.WriteLine($"Từ tiếng anh: {lovely.Key} => Nghĩa tiếng việt: {lovely.Value}");

            //====================================
            int[] integers = new int[] { 1, 2, 3, 5, 8, 9, 7, 0, 4 };
            double[] gpas = new double[] { 1.2, 3.5, 4.0, 2.54, 3.65, 3.24, 3.17 };
            ShowElements(integers);
            ShowElements(gpas);

            //====================================

            Console.WriteLine($"Max integer number: {FindMax(integers)}"); // 9
            Console.WriteLine($"Max gpa: {FindMax(gpas)}"); // 4
        }


        public static void ShowElements<T>(T[] arr)
        {
            foreach (T item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        // phương thức tìm phần tử lớn nhất trong mảng
        public static T FindMax<T>(T[] arr) where T : IComparable<T>
        {
            T max = arr[0];
            foreach (var item in arr)
            {
                if (item.CompareTo(max) > 0)
                {
                    max = item;
                }
            }
            return max;
        }
        class Utils
        {
            public static void Display<T>(T value) //để phương thức trờ thành generic cho <T>
            {
                Console.WriteLine(value);
            }
        }

        class TranscriptOfStudent<S, T>
        {
            public string SubjectName { get; set; }
            public S Student { get; set; }
            public T Transcript { get; set; }
            public TranscriptOfStudent()
            {

            }
            public TranscriptOfStudent(S student, T transcript, string subjectName)
            {
                Student = student;
                Transcript = transcript;
                SubjectName = subjectName;
            }
        }


        class Pair<K, V> //Đây là hình ảnh của lớp generic
        {
            public K Key { get; set; }
            public V Value { get; set; }
            public Pair(K key, V value)
            {
                Key = key;
                Value = value;
            }
        }
        
    }
}
