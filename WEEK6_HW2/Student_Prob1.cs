namespace WEEK6_HW2;

public class Student_Prob1
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int EnrollementYear { get; set; }

    
    public Student_Prob1(string name, int age, int enrollementYear)
    {
        Name =  name;
        Age = age;
        EnrollementYear = enrollementYear;
    }

    public string RandomSubject()
    {
        string[] subjects = new string[] { "მათემატიკა", "ქიმია", "ინგლისური", "ფიზიკა", "ისტორია" };

        var random = new Random();
        
        var index = random.Next(0, subjects.Length);
        
        return subjects[index];
    }

    public int YearsLeftToGraduate(int year)
    {

        var YearsSpent = year - EnrollementYear;

        var YearsLeft = 4 - YearsSpent;

        if (YearsLeft < 0)
        {
            YearsLeft = 0;
        }

        return YearsLeft;
    }
    
}