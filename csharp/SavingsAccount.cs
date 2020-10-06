namespace csharp
{
    public class SavingsAccount
    {
        // instance level data 
        public double currBalance;
        // A static point of data 
        public static double currInterestRate = 0.04;

        public SavingsAccount(double balance)
        {
            currInterestRate = 0.04; // this is static data
            currBalance = balance;
        }
        
        // static members to get/set interest rate 
        // this method will allow you to change the interest rate 
        public static void SetInterestRate(double newRate)
        {
            currInterestRate = newRate;
        }
        // the method will return interest rate 
        public static double GetInterestRate()
        {
            return currInterestRate;
        }
        
    }
}