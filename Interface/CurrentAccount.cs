
namespace Evaluation6
{
    public class CurrentAccount : IBankAccount
    {
        public double CalculateInterest()
        {
            double Rate = 3.5;
            double Time=2.5;
            double PrincipalAmount=15799.69;
            double interest = (PrincipalAmount * Rate * Time) / 100;
            return interest;
        }

        public void DisplayInfo(string AccountName,int AccountNumber)
        {
            System.Console.WriteLine("This is a Current Account Details");
            System.Console.WriteLine("Account Name: {0}",AccountName );
            System.Console.WriteLine("Your Account Number is: {0}",AccountNumber);

        }
    }
}