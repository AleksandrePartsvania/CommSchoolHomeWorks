namespace WEEK6_HW2;

public class Student_Prob3
{
    public string Name { get; set; }

    public Student_Prob3(string name)
    {
        Name = name;
    }

    public virtual void Study()
    {
        Console.WriteLine($"{Name} მეცადინეობს");
    }
    public virtual void Read()
    {
        Console.WriteLine($"{Name} კითხულობს");
    }
    public virtual void Write()
    {
        Console.WriteLine($"{Name} წერს");
    }
    public virtual void Relax()
    {
        Console.WriteLine($"{Name} ისვენებს");
    }
    
}