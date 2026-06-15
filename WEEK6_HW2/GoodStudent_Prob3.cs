namespace WEEK6_HW2;

public class GoodStudent_Prob3 : Student_Prob3
{
    public GoodStudent_Prob3(string name) : base(name) {}
    
    public override void Study()
    {
        Console.WriteLine($"{Name} სწავლობს კარგად.");
    }
    public override void Read()
    {
        Console.WriteLine($"{Name} კითხულობს ბევრ წიგნს.");
    }
    public override void Write()
    {
        Console.WriteLine($"{Name} წერს ძალიან კარგად.");
    }
    public override void Relax()
    {
        Console.WriteLine($"{Name} ისვენებს მაგრამ სულ სწავლაზე ფიქრობს.");
    }
}