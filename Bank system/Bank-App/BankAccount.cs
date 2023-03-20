namespace Bank
{
    public class BankAccount
    {
        private double money=0;
        private string ?name;
    public BankAccount(double money, string name)
    {
        this.money=money;
        this.name=name;

    }

    public void BankAccInfo(string name)
    {   
        
    }


    public void Deposit(double amount){
        money +=amount;
        System.Console.WriteLine(name+" you have deposited Rs.{0} in your account",money);
    }
    public void Withdraw(double money)
    {
        this.money -=money;
        System.Console.WriteLine(name +" you have withdrawn Rs.{0} from your account",money);

    }
    public void Getinfo()
    {
        System.Console.WriteLine(name +" has Rs."+ money+ " in the bank account");
    }

    }
}
