namespace WEEK3_HW2;

class Program
{
    static void Main(string[] args)
    {
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.Clear();
        
        Console.WriteLine("Aleksandre Partsvania");
        Console.Write("Enter your first name: ");
        var fName = Console.ReadLine();
        Console.Write("Enter your last name: ");
        var lName = Console.ReadLine();
        Console.WriteLine($"First Name: {fName}, Last Name: {lName}");
        Console.ResetColor();
    }
}