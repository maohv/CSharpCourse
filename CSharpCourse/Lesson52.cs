using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse
{
    class Lesson52
    {
        //Xử lý ngoại lệ
        static void Main()
        {
            //sử dụng try-catch
            //int[] arr = new int[5];
            //try
            //{
            //    arr[-1] = 100;
            //    arr[5] = 500;
            //}
            //catch (IndexOutOfRangeException e)
            //{
            //    Console.WriteLine(e.Message);
            //    Console.WriteLine(e.StackTrace);
            //}

            //sử dụng try-finally
            FileStream file = null;
            FileInfo fileInfo = new FileInfo("data.txt");
            try
            {
                file = fileInfo.OpenWrite();
                file.WriteByte(0xF);
            }
            finally
            {
                file?.Close(); //check bằng null
            }

            //sử dụng try-catch-finally
            StreamReader reader = null;
            try
            {
                reader = new StreamReader("input.txt");
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            catch(FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Ten file hoac k dung duong dan");
            }
            finally
            {
                reader?.Close();
            }
        }

        static int GetInt(int[] arr, int index)
        {
            try
            {
                return arr[index];
            }
            catch (IndexOutOfRangeException e) when (index < 10)
            {
                throw new AggregateException("Parameter index cannot be negative.", e);
            }
            catch (IndexOutOfRangeException e)
            {
                throw new AggregateException("Parameter index cannot be greater than the arry size", e);
            }
        }

    }
}
