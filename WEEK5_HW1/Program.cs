namespace WEEK5_HW1;

class Program
{
    static void Main(string[] args)
    {
        /*
        #region Problem1

        var x = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[x];
        for (int i = 0; i < x; i++)
        {
            var y = Convert.ToInt32(Console.ReadLine());
            arr[i] = y;
        }

        int[] arr2 = new int[x];
        int[] arr3 = new int[x];

        for (int i = 0; i < x; i++)
        {
            if (arr[i] % 2 == 0) arr2[i] = arr[i];
            else arr3[i] = arr[i];
        }

        foreach (var item in arr2)
        {
            if (item > 0) Console.Write($"{item} ");
        }
        Console.WriteLine();
        foreach (var item in arr3)
        {
            if (item > 0) Console.Write($"{item} ");
        }
        #endregion
        */

        /*
        #region Problem2

        Dictionary<string, string> contacts = new Dictionary<string, string>();

        while (true)
        {
            Console.WriteLine("\n    Contacts    ");
            Console.WriteLine("1. Add contact");
            Console.WriteLine("2. Delete contact");
            Console.WriteLine("3. Update contact");
            Console.WriteLine("4. Exit\n");
            
            Console.Write("Choose: ");
            var x = Convert.ToInt32(Console.ReadLine());
            switch (x)
            {
                case 1:
                    Console.Write("Enter name: ");
                    var name = Console.ReadLine();
                    Console.Write("Enter a phone number: ");
                    var number = Console.ReadLine();

                    if (!contacts.ContainsKey(name))
                    {
                        contacts.Add(name, number);
                        Console.WriteLine("Contact added");
                    }
                    else Console.WriteLine("Contact exists");

                    break;
                
                case 2:
                    Console.Write("Enter name to delete: ");
                    var nameToDelete = Console.ReadLine();
                    if (contacts.Remove(nameToDelete))
                    {
                        Console.WriteLine("Contact deleted");
                    }
                    else Console.WriteLine("Contact not found");

                    break;
                
                case 3:
                    Console.Write("Enter name to update: ");
                    var nameToUpdate = Console.ReadLine();
                    if (contacts.ContainsKey(nameToUpdate))
                    {
                        Console.Write("Enter number to update: ");
                        var phoneToUpdate = Console.ReadLine();
                        contacts[nameToUpdate] = phoneToUpdate;
                        Console.WriteLine("Number updated");
                    }
                    else Console.WriteLine("Contact not found");

                    break;
                
                case 4:
                    Console.WriteLine("Goodbye");
                    break;
                
                default:
                    Console.WriteLine("Incorrect choice!");
                    break;
            }

            if (x == 4)
            {
                return;
            }
        }
        #endregion
        */

        /*
        #region Problem3

        var input = Console.ReadLine();
        string[] splitted = input.Split(' ');
        int[] splittedInt = splitted.Select(x => Convert.ToInt32(x)).ToArray();

        foreach (var item in splittedInt.Distinct())
        {
            var count = splittedInt.Count(x => x == item);
            var sum = splittedInt.Where(x => x == item).Sum();
            Console.WriteLine($"{item} appears {count} times sum {sum}");
        }

        #endregion
        */

        /*
        #region Problem4

        var input = Console.ReadLine();
        var x = Convert.ToInt32(Console.ReadLine());
        int[] arr = input.Split(' ').Select(int.Parse).ToArray();
        var result = arr.OrderByDescending(x => x).Take(x);
        Console.WriteLine(string.Join(" ", result));
        #endregion
        */
    }
}