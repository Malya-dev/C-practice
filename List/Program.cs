using System;
using System.Collections.Generic;
using System.Collections;

namespace ListExamples
{
    public class Programs
    {
        public static void Main(string[] args)
        {
    
            List<int> myList = new List<int>();
            System.Console.WriteLine("Enter as many numbers you want");
            System.Console.WriteLine("Press enter to stop");

            while (true)
            {
                var input = Console.ReadLine();
                
                if (input=="")
                    break;
                else
                    myList.Add(Convert.ToInt32(input));

            }

            System.Console.WriteLine("The List is:");
            System.Console.Write(string.Join(",",myList.ToArray()));

            System.Console.WriteLine();
            // Remove all elements that are matching with the condtion
            myList.RemoveAll( n=> n%2==0);
            System.Console.WriteLine("List after removing even numbers:{0}", string.Join(",",myList.ToArray()));

        }


    }
}
