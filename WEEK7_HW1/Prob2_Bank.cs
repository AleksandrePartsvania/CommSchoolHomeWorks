namespace WEEK7_HW1;

public class Prob2_Bank : Prob2_FinanceOperations
{
    private Random _random = new Random();

    public bool CheckUserHistory()
    {
        return _random.Next(0, 2) == 1;
    }

    public double CalculateLoanPercentage(int month, double AmountPerMonth)
    {
        double principalAmount = month * AmountPerMonth; 
        double interest = principalAmount * 0.05;        
        return principalAmount + interest;
    }
    
    
}