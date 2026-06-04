namespace WEEK5_HW2;

class Program
{
    static void Main(string[] args)
    {
        /*
        #region Problem1

        var difference = 0d;
        if (double.TryParse(Console.ReadLine(), out double radius))
        {
            difference = 2 * Math.Pow(radius, 2);
        }

        Console.WriteLine(difference);
        #endregion
        */

        /*
        #region Problem2
        var input = Console.ReadLine();
        var arr = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        if (arr.Length == 0)
        {
            Console.WriteLine("No"); 
            return;
        }
        var isJackpot = arr.All(x => x == arr[0]);
        Console.WriteLine(isJackpot ? "Yes" : "No");
        #endregion
        */

        /*
        #region Problem3

        var input = Console.ReadLine();
        var arr = input.Split((char[])null, StringSplitOptions.RemoveEmptyEntries).Select(x => Convert.ToInt32(x)).ToArray();
        int win = arr[0], draw = arr[1], loss = arr[2];
        Console.WriteLine(win * 3 + draw * 1);
        #endregion
        */

        /*
        #region Problem4

        var input = Console.ReadLine();
        var days = input.Split(',').Select(x => Convert.ToInt32(x.Trim())).ToArray();
        var salary = 0;
        for (int i = 0; i < days.Length; i++)
        {
            if (i == days.Length - 1 || i == days.Length - 2)
            {
                if (days[i] <= 8) salary += days[i] * 20;
                else salary += days[i] - 8 * 30;
            }
            else if (days[i] <= 8) salary += days[i] * 10;
            else if (days[i] > 8)
            {
                salary += days[i] - 8 * 15;
                salary += 80;
            }
            
        }

        Console.WriteLine(salary);
        #endregion
        */

        /*
        #region Problem5

        var input = Console.ReadLine();
        var arr = input.Split(',').Select(x => Convert.ToInt32(x.Trim())).ToArray();
        var isProgress = true;
        int count = 0;
        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] < arr[i + 1])
            {
                count++;
            }
        }

        Console.WriteLine(count);
        #endregion
        */

        /*
        #region Problem6

        var input = Console.ReadLine();
        var arr = input.Split(',').Select(x => Convert.ToString(x.Trim())).ToArray();
        var target = Convert.ToInt32(Console.ReadLine());
        var result = arr.Where(x => x.Length == target).ToList();
        Console.WriteLine(string.Join(" ", result));
        #endregion
        */
    }
}