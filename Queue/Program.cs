using System;
using System.Collections;
using System.Collections.Generic;

namespace Practice
{
    public class Program
    {
        static void Main()
        {
            // Generic Queue
            Queue<string> queue=new Queue<string>();
            queue.Enqueue("Customer 9");
            queue.Enqueue("Customer 7");
            queue.Enqueue("Customer 5");
            queue.Enqueue("Customer 2");
            queue.Enqueue("Customer 0");

            string dq=queue.Dequeue();
            System.Console.WriteLine("Dequeued item:{0}",dq);

            string pk=queue.Peek();
            System.Console.WriteLine("peeked item:{0}",pk);

            foreach( var items in queue)
            {
                System.Console.WriteLine(items);
            }
            System.Console.WriteLine();

            // Non Generic
            Queue kyu=new Queue();
            System.Console.WriteLine("Enter as many Elements you want in your Queue");
            System.Console.WriteLine("Press Enter key to Stop");
            while(true)
            {
                var input=Console.ReadLine();
                if(input=="") //Console.ReadKey().key=ConsoleKey.Enter
                    break;
                else
                    kyu.Enqueue(input);
            }
            System.Console.WriteLine("Elements in the Queue:");
            System.Console.ReadKey();
            foreach(var items in kyu)
            {
                System.Console.WriteLine(items);
            }
            System.Console.WriteLine("The No of elements in the queue:"+kyu.Count);
        }
    }
}