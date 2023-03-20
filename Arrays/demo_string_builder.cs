using System;
using System.Text;

namespace evaluation
{
    public class demo_string_builder
    {
        public void stringshow()
        {
            StringBuilder str = new StringBuilder("Hello ",100);
            str.AppendLine("I am debmalya");
            str.Append("I am learning java");

            System.Console.WriteLine(str);
            System.Console.WriteLine();

            str.Append(" Basics");
            str.Replace("java","c#");

            System.Console.WriteLine(str);
            System.Console.WriteLine();

            str.Insert(6," Hi Everyone ");
            System.Console.WriteLine(str);
            System.Console.WriteLine();

            str.Remove(6,4);
            System.Console.WriteLine(str);

            System.Console.WriteLine("enter any new string");
            string s1=Console.ReadLine()!;
            var ssb=new StringBuilder(s1,100);
           
            Console.ForegroundColor=ConsoleColor.Cyan;
            System.Console.WriteLine(ssb); 
            ssb.Append(" "+"you are doing well");
            System.Console.WriteLine(ssb);
            Console.ResetColor();


            // System.Console.WriteLine("Enter any string");
            // string s1 = str.ToString();
            // s1 = Console.ReadLine()!;

            // for (int i = 0; i < s1.Length; i++)
            // {
            //     System.Console.WriteLine(s1[i]);
            // }

            // System.Console.WriteLine("after cloning");
            // string s2=(string)s1.Clone();
            // System.Console.WriteLine(s2);
            
        }
    }
}

