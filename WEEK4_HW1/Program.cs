namespace WEEK4_HW1;

class Program
{
    static void Main(string[] args)
    {
        /*
        #region Problem1
        Console.Write("Enter your number: ");
        int number;
        while (true)
        {
            if (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.Write("Try again: ");
            }
            else
            {
                break;
            }
        }
        Console.WriteLine(number % 5 == 0 ? "Yes" : "No");
        #endregion
        */
        
        /*
        #region Problem2
        Console.Write("Enter number 1: ");
        int x;
        while (true)
        {
            if (!int.TryParse(Console.ReadLine(), out x))
            {
                Console.Write("Try again: ");
            }
            else
            {
                break;
            }
        }
        
        Console.Write("Enter number 2: ");
        int y;
        while (true)
        {
            if (!int.TryParse(Console.ReadLine(), out y))
            {
                Console.Write("Try again: ");
            }
            else
            {
                break;
            }
        }

        var sum = x + y;
        var diff = x > y ? x - y : y - x;
        var prod = x * y;
        
        Console.WriteLine($"\nSum of X and Y: {sum}");
        Console.WriteLine($"Substraction of X and Y: {diff}");
        Console.WriteLine($"Product of X and Y: {prod}");
        
        int div = 0;
        if (x > y)
        {
            if (y == 0)
            {
                Console.WriteLine("Not allowed to divide by zero!");
            }
            else
            {
                div = x / y;
            }
        }
        else if (y > x)
        {
            if (x == 0)
            {
                Console.WriteLine("Not allowed to divide by zero");
            }
            else
            {
                div = y / x;
            }
        }
        else
        {
            div = 1;
        }
        
        Console.WriteLine(div != 0 ? $"Division of X and Y: {div}" : "");
        #endregion
        */

        /*
        #region Problem3
        Console.Write("Enter num 1: ");
        var x = int.Parse(Console.ReadLine());
        Console.Write("Enter num 2: ");
        var y = int.Parse(Console.ReadLine());

        var temp = x;
        x = y;
        y = temp;
        
        Console.WriteLine($"X: {x}, Y: {y}");
        #endregion
        */

        /*
        #region Problem4
        Console.Write("Enter number: ");
        var x = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 9; i++)
        {
            Console.WriteLine($"{x} * {i} = {x * i}" );
        }
        #endregion
        */

        /*
        #region Problem5
        Console.Write("Enter number: ");
        var x = int.Parse(Console.ReadLine());

        for (int i = 1; i < x; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(Math.Pow(i, 2));
            }
        }
        #endregion
        */
    }
}