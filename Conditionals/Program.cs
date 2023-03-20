using System;
using System.Collections.Generic;

namespace Conditional
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("enter the size of array");
            int n=Convert.ToInt32(System.Console.ReadLine());
            int[] arr=new int[n];
            System.Console.WriteLine("enter the number of elements:");            
            for(int i=0;i<n;i++)
            {
                arr[i]=Convert.ToInt32(Console.ReadLine());
            }
            System.Console.WriteLine("printing the array after taking input:");
            foreach(int items in arr)
            {
                // if (items==3)
                    // goto wow;
    
                System.Console.WriteLine(items);
            }

            // wow: System.Console.WriteLine("I'm out of the loop wow");

            var rev=new reverse();
            rev.rvrs();

            // var pnum=new PrimeNUmbers();
         
            // pnum.prime();


            var cal= new Demo();
            cal.Calculator();

           
        }
       
    }
}