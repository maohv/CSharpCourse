using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace File_Vi_Du
{
    class TestConnection_SQL
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            //var connString = "Data Source=DESKTOP-9L14R4S;Initial Catalog=LearnCSharp;Persist Security Info=True;User ID=sa;Password=12345a@";
            var connString = "Data Source=HoangMao;Initial Catalog=LearnCSharp;Persist Security Info=True;User ID=sa;Password=12345a@";    
            var conn = DBUtils.GetConnection(connString);

            //Truy vấn DELETE
            //Console.WriteLine("Nhập tên đệm của bản ghi cần xóa: ");
            //var midName = Console.ReadLine();
            //var sql = $"DELETE FROM Person WHERE MidName=N'{midName}'";

            //Truy vấn INSERT
            //var sql = $"INSERT INTO Person(FirstName, LastName, MidName, Age, Address) " +
            //    $"VALUES(@first, @last, @mid, @age, @address)";

            ////Chen du lieu vao bang
            //var sql1 = "SET IDENTITY_INSERT Person ON; ";
            //var sql2 =
            //    "INSERT INTO Person(Id, FirstName, LastName, MidName, Age, Address) " +
            //    "VALUES(@id, @first, @last, @mid, @age, @address)";
            //var sql3 = "SET IDENTITY_INSERT Person OFF";
            //var people = CreatePeople(); // danh sách người cần thêm vào bản

            //Truy vấn ALTER TABLE
            //// var sql = "ALTER TABLE Person DROP CONSTRAINT DF__Person__PhoneNum__48CFD27E; 
            // var sql = "ALTER TABLE Person ADD Salary FLOAT NOT NULL DEFAULT(0)"; ////add cột Salary k cho phép null với giá trị mặc định là 0
            // var sql = "ALTER TABLE Person DROP COLUMN Salary"; ////Xóa cột Salary
            //var sql = "ALTER TABLE Person ALTER COLUMN Email NVARCHAR(40)"; //Sửa kiểu dữ liệu của cột Email sang NVACHAR(40)

            //Truy vấn tạo bảng, tạo CSDL
            //var sqlCreateTable = "CREATE TABLE Student(" +
            //   "Id INT IDENTITY(100, 2) NOT NULL," +
            //   "FullName NVARCHAR(50) NULL," +
            //   "Gpa FLOAT NOT NULL DEFAULT(0)," +
            //   "Major NVARCHAR(50) NULL," +
            //   "PRIMARY KEY CLUSTERED (Id ASC)" +
            //   ")";
            ////Truy vấn xóa bảng dữ liệu
            //var sqlDeleteTable = "DROP TABLE Student";

            try
            {
                conn.Open();
                Console.WriteLine("Ket noi DB thanh cong");
                //Console.WriteLine("Database Name: " + conn.Database);

                //Truy vấn SELECT
                //var people = FindAll(conn);
                //ShowInfo(people);

                //=============================================

                //Truy vấn DELETE
                //var result = Remove(conn, sql);
                //if (result > 0)
                //{
                //    Console.WriteLine($"Xóa thành công {result} bản ghi khỏi bảng.");
                //}
                //else
                //{
                //    Console.WriteLine("Xóa thất bại. Bản ghi cần xóa không tồn tại.");
                //}

                //=============================================

                //Truy vấn INSERT
                //var result = InsertData(conn, sql);
                //Console.WriteLine($"{result} dòng đã được chèn vào bảng.");

                //=============================================

                ////Chen du lieu vao bang
                //var command = conn.CreateCommand();
                //// cho phép chèn vào cột tự tăng trong bảng Person
                //command.CommandText = sql1;
                //command.ExecuteNonQuery();
                //// tiến hành setup các tham số, giới hạn độ dài dữ liệu nếu có
                //command.CommandText = sql2;
                //command.Parameters.Add("@id", SqlDbType.Int);
                //command.Parameters.Add("@first", SqlDbType.NVarChar, 50);
                //command.Parameters.Add("@last", SqlDbType.NVarChar, 50);
                //command.Parameters.Add("@mid", SqlDbType.NVarChar, 50);
                //command.Parameters.Add("@age", SqlDbType.Int);
                //command.Parameters.Add("@address", SqlDbType.NVarChar, 50);
                //command.Prepare();
                //foreach (var person in people)
                //{
                //    command.Parameters[0].Value = person.Id;
                //    command.Parameters[1].Value = person.FirstName;
                //    command.Parameters[2].Value = person.LastName;
                //    command.Parameters[3].Value = person.MidName;
                //    command.Parameters[4].Value = person.Age;
                //    command.Parameters[5].Value = person.Address;
                //    command.ExecuteNonQuery();
                //}
                //// tắt chức năng cho phép chèn vào cột tự động tăng trong bảng
                //command.CommandText = sql3;
                //command.ExecuteNonQuery();
                //Console.WriteLine("Chen du lieu vao bang thanh cong");

                //=========================================

                //Truy vấn ALTER TABLE
                //var command = conn.CreateCommand();
                //command.CommandText = sql;
                //command.ExecuteNonQuery();

                //Truy vấn tạo bảng, tạo CSDL
                //var cmd = conn.CreateCommand();
                //cmd.CommandText = sqlDeleteTable;
                //cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {

                Console.WriteLine(e);
            }
            finally
            {
                conn.Close();
            }
        }
        private static List<Person> CreatePeople()
        {
            var people = new List<Person>();
            people.Add(new Person(150, "Long", "Phạm", "Đình", 20, "Nghệ An"));
            people.Add(new Person(151, "Linh", "Trần", "Hạo", 20, "Hà Nam"));
            people.Add(new Person(152, "Liên", "Ngô", "Thu", 20, "Cà Mau"));
            people.Add(new Person(153, "Hồng", "Lê", "Thị Minh", 21, "Bình Dương"));
            people.Add(new Person(154, "Luyến", "Nông", "Thị Lưu", 20, "Tây Ninh"));
            people.Add(new Person(155, "Nga", "Vũ", "Thị Thu", 21, "Hà Tĩnh"));
            return people;
        }
        private static void ShowInfo(List<Person> people)
        {
            foreach (var person in people)
            {
                Console.WriteLine(person);
            }
        }

        private static int Remove(SqlConnection conn, string sql)
        {
            var cmd = new SqlCommand(sql, conn);
            try
            {
                return cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
            }
            return 0;
        }

        private static int InsertData(SqlConnection conn, string sql)
        {
            Console.WriteLine("Tên: ");
            var first = Console.ReadLine();
            Console.WriteLine("Họ: ");
            var last = Console.ReadLine();
            Console.WriteLine("Đệm: ");
            var mid = Console.ReadLine();
            Console.WriteLine("Địa chỉ: ");
            var address = Console.ReadLine();
            Console.WriteLine("Tuổi: ");
            var age = int.Parse(Console.ReadLine());

            var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add("@first", SqlDbType.NVarChar).Value = first;
            cmd.Parameters.Add("@last", SqlDbType.NVarChar).Value = last;
            cmd.Parameters.Add("@mid", SqlDbType.NVarChar).Value = mid;
            cmd.Parameters.Add("@address", SqlDbType.NVarChar).Value = address;
            cmd.Parameters.Add("@age", SqlDbType.Int).Value = age;
            try
            {
                return cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
            }
            return 0;
        }

        static List<Person> FindAll(SqlConnection conn)
        {
            List<Person> list = new List<Person>();
            string sql = "SELECT * FROM Person";
            var cmd = new SqlCommand(sql, conn);
            using (var reader = cmd.ExecuteReader()) //ExecuteReader cho phép đọc cột dữ liệu từ trong bảng ra
            {
                if (reader.HasRows) //có các dòng dữ liệu để tiếp tục đọc thì mới vào trong để đọc
                {
                    while (reader.Read())
                    {

                        int id = reader.GetInt32(0); // GetInt32 tương đương với int
                        string fist = reader.GetString(1);
                        string last = reader.GetString(2);
                        string mid = reader.GetString(3);
                        int age = reader.GetInt32(4);
                        string address = reader.GetString(5);
                        list.Add(new Person(id, fist, last, mid, age, address));
                    }
                }
            }
            return list;
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MidName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public Person()
        {

        }
        public Person(int id, string first, string last, string mid, int age, string address)
        {
            Id = id;
            FirstName = first;
            LastName = last;
            MidName = mid;
            Age = age;
            Address = address;
        }
        public override string ToString() => $"Person [Id = {Id}, [FirstName: {FirstName}], [LastName: {LastName}], [MidName: {MidName}], [Age: {Age}], [Address: {Address}] ";

    }

  
}
