namespace WEEK6_HW1;

class Program
{
    static void Main(string[] args)
    {
        /*
        #region Problem1

        var a = Convert.ToInt32(Console.ReadLine());
        var b = Convert.ToInt32(Console.ReadLine());
        var c = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(CountAll(a, b, c));
        #endregion
        */

        /*
        #region Problem2

        var inputArr = Console.ReadLine().ToCharArray();
        Console.WriteLine(CountSocks(inputArr));

        #endregion
        */

        /*
        #region Problem3
        var x = Console.ReadLine();
        var y = Console.ReadLine();
        Similar(x, y);
        #endregion
        */

        /*
        #region Problem4

        var list1 = new List<int>() { 1, 2, 3, 4, 5 };
        var list2 = new List<string>() { "a", "b", "c", "d", "e" };
        var list3 = new List<bool>() { true, false, false, true, true };
        Method(list1);
        Method(list2);
        Method(list3);

        #endregion
        */

        /*
        #region Problem5
        var input = Convert.ToInt32(Console.ReadLine());
        Recursive(input);
        #endregion
        */

        /*
        #region Problem6
        var input = Console.ReadLine();
        var arr = input.Split((char[])null, StringSplitOptions.RemoveEmptyEntries).Select(x => Convert.ToInt32(x))
            .ToArray();
        if (AreDuplicates(arr))
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
        #endregion
        */
    }

    /*
    #region MethodForProblem1

    static int CountAll(int a, int b, int c)
    {
        int count = 0;
        for (int i = (int)Math.Sqrt(a); i <= (int)Math.Sqrt(b); i++)
        {
            if (Math.Pow(i, c) >= a && Math.Pow(i, c) <= b) count++;
        }

        return count;
    }
    #endregion
    */

    /*
    #region MethodForProblem2

    static int CountSocks(char[] arr)
    {
        int count = 0;
        foreach (var item in arr.Distinct())
        {
            count += arr.Count(x => x == item) / 2;
        }

        return count;
    }
    #endregion
    */

    /*
    #region MethodForProblem3

    static void Similar(string a, string b)
    {
        var x = a.Length - 1;
        var y = b.Length - 1;
        while (x >= 0 && y >= 0 && a[x] == b[y])
        {
            x--;
            y--;
        }

        Console.WriteLine(a.Substring(x + 1));
    }
    #endregion
    */

    /*
    #region MethodForProblem4

    static void Method<T>(List<T> list)
    {
        if (typeof(T) == typeof(int))
        {
            var result = list.ConvertAll(x => Convert.ToInt32(x)).Sum();
            Console.WriteLine(result);
        }
        else if (typeof(T) == typeof(string))
        {
            var result = list.ConvertAll(x => Convert.ToString(x)).Select(x => (x.ToUpperInvariant()));
            foreach (var item in result)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();
        }
        else if (typeof(T) == typeof(bool))
        {
            var result = list.ConvertAll(x => Convert.ToBoolean(x));
            Console.WriteLine($"{list[0]} {list[(list.Count - 1) / 2]} {list[list.Count - 1]}");
        }
    }
    #endregion
    */

    /*
    #region MethodForProblem5

    static void Recursive(int x)
    {
        if (x < 10)
        {
            Console.Write(x % 10);
            return;
        }

        Recursive(x / 10);
        Console.Write($"-{x % 10}");
    }
    #endregion
    */

    /*
    #region MethodForProblem6
    static bool AreDuplicates<T>(T[] arr)
    {
        if (arr.Length != arr.Distinct().ToArray().Length)
        {
            return true;
        }

        return false;
    }
    #endregion
    */
}