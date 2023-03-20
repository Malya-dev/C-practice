using System;
using System.Collections.Generic;
using System.Collections;

namespace Hash
{
    public class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashExample = new Hashtable()
            {
                {"this",101},
                {301,"hashTable"},
                {69.30,89.62},
            };

            

            foreach (var items in hashExample.Keys)
            {
                System.Console.WriteLine(items);
            }
            System.Console.WriteLine();
            foreach (var items in hashExample.Values)
            {
                System.Console.WriteLine(items);
            }

        }
    }
}