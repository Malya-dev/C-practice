namespace Evaluation6
{
    interface IShare: IBankAccount
    {
        int Addstocks()
        {
            System.Console.WriteLine("hello");
            return 9;
        }
        string Name{
            get;
            set;
        }
        
        int Number{
            get;set;
        }
        public void IntraDay();
        void CashOnDelivery();
    }

    public class Shares: IShare
    {
        // private string _name;
        public string? Name {    
                get;
                set;
                }
        public int Number { 
            get;
            set;
        }
        public void IntraDay()
        {
            System.Console.WriteLine("You choose intraday");
        }

        public void CashOnDelivery()
        {
            System.Console.WriteLine("You choose COD");
        }

        public double CalculateInterest()
        {
            throw new NotImplementedException();
        }

        public void DisplayInfo(string AccountName, int AccountNumber)
        {
            throw new NotImplementedException();
        }
    }
}

