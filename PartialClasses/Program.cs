using System;
 namespace Evaluation6
 {
    class Program
    {
        static void Main(string[] args)
        {
            Debmalya income=new Debmalya();
            income.Company="";
            income.FirstName="Debmalya";
            income.Basics=2000;
           
            System.Console.WriteLine(income.FirstName);
            System.Console.WriteLine(income.Company);
            income.GetSalary();
            // income.CallGetSalary();
        }
    }
 }