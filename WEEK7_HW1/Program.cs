namespace WEEK7_HW1;

class Program
{
    static void Main(string[] args)
    {
        /*
        #region Problem1

        var x = new Prob1_TextWorker(256);
        x.Write();
        x.Read();
        x.Delete();
        x.Edit();

        #endregion
        */

        /*
        #region Prolem2

        int months = 2;
        double amountPerMonth = 200;

        Prob2_FinanceOperations bank = new Prob2_Bank();
        
        if (bank.CheckUserHistory())
        {
            double totalBankPayable = bank.CalculateLoanPercentage(months, amountPerMonth);
            Console.WriteLine($"სესხი!");
            Console.WriteLine($"ჯამში გადასახდელი თანხა 5%-იანი განაკვეთით: {totalBankPayable}$\n");
        }
        else
        {
            Console.WriteLine("სამწუხაროდ, ბანკმა სესხზე უარი გითხრათ.\n");
        }

        // --- მიკროსაფინანსოს ტესტირება ---
        Prob2_FinanceOperations microFinance = new Prob2_MicroFinance();
        Console.WriteLine("მოწმდება მომხმარებლის ისტორია...");
            
        if (microFinance.CheckUserHistory())
        {
            double totalMicroPayable = microFinance.CalculateLoanPercentage(months, amountPerMonth);
            Console.WriteLine($"მიკროსაფინანსომ დაამტკიცა სესხი! (ყოველთვის მტკიცდება)");
            Console.WriteLine($"ჯამში გადასახდელი თანხა (10% საკომისიო + 4$ ყოველთვიურად): {totalMicroPayable}$\n");
        }
        #endregion
        */
    }
}