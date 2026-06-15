namespace WEEK7_HW1;

public class Prob2_MicroFinance : Prob2_FinanceOperations
{
    public bool CheckUserHistory()
    {
        return true;
    }

    public double CalculateLoanPercentage(int month, double AmountPerMonth)
    {
        double principalAmount = month * AmountPerMonth;
        double commission = principalAmount * 0.10;  
        double serviceFee = month * 4;               
        return principalAmount + commission + serviceFee;
    }
}