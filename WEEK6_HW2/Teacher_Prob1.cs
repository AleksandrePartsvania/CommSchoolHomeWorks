namespace WEEK6_HW2;

public class Teacher_Prob1
{
    public string Name { get; set; }
    public bool IsCertified { get; set; }

    public Teacher_Prob1(string name, bool isCertified)
    {
        Name = name;
        IsCertified = isCertified;
    }

    public void CheckSubject(string subject)
    {
        var random = new Random();
        if (subject == "მათემატიკა")
        {
            var num1 = random.Next(100, 1001);
            var num2 = random.Next(100, 1001);

            Console.WriteLine($"{num1 + num2}");
        }
        else if (subject == "ქიმია")
        {
            Console.WriteLine("H20");
        }
        else if (subject == "ინგლისური")
        {
            Console.WriteLine("Hello World");
        }
        else
        {
            Console.WriteLine($"არ არის კომპეტენტური საგანში: {subject}");
        }
    }
}