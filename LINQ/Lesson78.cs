﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Lesson78
    {
        //Sắp xếp dữ liệu
        /*
         * Sắp xếp kết quả truy vấn trong LINQ bằng phương thức và biểu thức truy vấn
         * 1. Sắp xếp tăng dần theo một tiêu chí: ascending
         * 2. Sắp xếp giảm dần theo 1 tiêu chí: descending
         * 3. Sắp xếp tăng dần theo nhiều tiêu chí
         * 4. Sắp xếp giảm dần theo nhiều tiêu chí
         */
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            // danh sách sinh viên
            var students = new List<Student>()
            {
                new Student("B25DCCN107", "Trần Trung Đức", "Hà Nội"),
                new Student("B25DCCN100", "Trần Trung Đức", "Cao Bằng"),
                new Student("B25DCCN105", "Lê Khả Ngân", "Nam Định"),
                new Student("B25DCCN103", "Hoàng Thanh Mai", "Đà Nẵng"),
                new Student("B25DCCN109", "Nguyễn Thúy Quyên", "Hà Nội"),
                new Student("B25DCCN106", "Nông Tiến Mạnh", "Thái Nguyên"),
                new Student("B25DCCN101", "Hồ Hoài Anh", "Hà Nội"),
                new Student("B25DCCN104", "Trương Thanh Thức", "Hồ Chí Minh"),
                new Student("B25DCCN108", "Đỗ Hoàng Long", "Hồ Chí Minh")
            };


            //var studentsQuery = from student in students
            //                    orderby student.Address ascending, student.Id ascending // sắp xếp tăng dần
            //                    select student;

            var studentsQuery = students.Select(student => student)
                                        .OrderBy(student => student.Id) 
                                        .ThenBy(student => student.Id); //thenby tiếp tục theo tiêu chí tăng dần
            foreach (var item in studentsQuery)
            {
                Console.WriteLine(item);
            }
        }
    }
}
