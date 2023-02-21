public class Lesson35
{
    static void Main()
    {

        //tạo record của Student

        //Student student = new Student()
        //{
        //    Id = "ST1001",
        //    FullName = "Hoang Mao",
        //    Age= 24,
        //};
        //Console.WriteLine(student);
        //Kết quả: Student { Id = ST1001, FullName = Hoang Mao, Age = 24 }

        //===============================//

        //tạo ra đối tượng record Person

        //Person person = new Person("Hoang", "Mao", new string[]{"0705 050 399"});
        //Person other = person with { LastName = "Meo" }; //sao chép và thay đổi lastName
        //Console.WriteLine(person);
        //Console.WriteLine(other);
        //Console.WriteLine(person.PhoneName[0]);
        ////Thay đổi số điện thoại
        //other.PhoneName[0] = "0000 111 222";
        //Console.WriteLine(person.PhoneName[0]);
        //Console.WriteLine(other.PhoneName[0]);

        //===================================//

        //DailyTemerature[] data = new DailyTemerature[]
        //{
        //    new DailyTemerature(30,12),
        //    new DailyTemerature(22,10),
        //    new DailyTemerature(10,12),
        //    new DailyTemerature(22,32),
        //};
        //ShowTempData(data);

        //=================================//

        DailyTemerature toDayTemp = new DailyTemerature(30, 12);
        var nextDayTemp = toDayTemp with { Hightemp = 35 };
        var otherTemp = toDayTemp with { };
        Console.WriteLine(toDayTemp);
        Console.WriteLine(nextDayTemp);
        Console.WriteLine(toDayTemp == nextDayTemp);
        Console.WriteLine(toDayTemp == otherTemp);
        
    }

    private static void ShowTempData(DailyTemerature[] data)
    {
        foreach (var item in data)
        {
            Console.WriteLine(item);
        }
    }

    public record class Person(string FirstName, string LastName, string[] PhoneName)
    {

    }
}

//public record Person(string FirstName, string LastName);

public record Student
{
    public string Id { get; init; } = default!;

    public string FullName { get; init; } = default!;
    public int Age { get; init; } = default!;
}

public readonly record struct DailyTemerature(double Hightemp, double LowTemp)
{
    public double Mean => (LowTemp + Hightemp) / 2;
}

 