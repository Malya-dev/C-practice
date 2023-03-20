using System;

namespace Evaluation6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor=ConsoleColor.Blue;

            // savings acc. object
            SavingsAccount sb=new SavingsAccount();
            sb.DisplayInfo("Elon Musk", 123456987);
            System.Console.WriteLine("Your interest is:");
            System.Console.WriteLine(sb.CalculateInterest());
            System.Console.WriteLine();

            // using reference of interfence to call interface obj
            IBankAccount obj= sb;
            System.Console.WriteLine(obj.CalculateInterest());
            System.Console.WriteLine();
            

            // current acc. object
            CurrentAccount ca= new CurrentAccount();
            ca.DisplayInfo("Jeff Bezos",123456789);
            System.Console.WriteLine("Your interest is:");
            System.Console.WriteLine(ca.CalculateInterest());
            System.Console.WriteLine();

            IBankAccount obj1=ca;
            System.Console.WriteLine(obj1.CalculateInterest());
            System.Console.WriteLine();

            // shares obj creation
            Shares share=new Shares();
            share.IntraDay();
            share.CashOnDelivery();
            System.Console.WriteLine(share.Name);
            share.Name="hello";
            System.Console.WriteLine(share.Name);
            System.Console.WriteLine(share.Number=99);
            System.Console.WriteLine();

            IShare obj2=share;
            System.Console.WriteLine( obj2.Addstocks());



            Console.ResetColor();
        }
    }
}
