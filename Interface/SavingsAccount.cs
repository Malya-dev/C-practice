
namespace Evaluation6
{
    public class SavingsAccount : IBankAccount
    {
        public double CalculateInterest()
        {
            double Rate = 7.5;
            double Time=2.5;
            double PrincipalAmount=15799.69;
            double interest = (PrincipalAmount * Rate * Time) / 100;
            return interest;
        }
    
        public void DisplayInfo(string AccountName,int AccountNumber)
        {
            System.Console.WriteLine("This is a savings Account Details");
            System.Console.WriteLine("Account name:{0}", AccountName);
            System.Console.WriteLine("Your Account number is:{0}", AccountNumber);
        }
    }

}