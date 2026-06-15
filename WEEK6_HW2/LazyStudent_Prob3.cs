namespace WEEK6_HW2;

public class LazyStudent_Prob3 : Student_Prob3
{
    public LazyStudent_Prob3(string name) : base(name) {}
    
    public override void Study()
    {
        Console.WriteLine($"{Name} თითქმის არ სწავლობს.");
    }
    public override void Read()
    {
        Console.WriteLine($"{Name} არ კითხულობს.");
    }
    public override void Write()
    {
        Console.WriteLine($"{Name} წერს დაძალებით.");
    }
    public override void Relax()
    {
        Console.WriteLine($"{Name} ყოველთვის ისვენებს.");
    }
}