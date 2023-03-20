using System;
using System.Collections.Generic;
using System.Collections;
namespace practice
{
    class Task
    {
        public int Time { get; set; }
        public string? Details { get; set; }
    }

    public class Program
    {
        static void Main()
        {
            //Generic stack            
            Stack<Task> TaskStack = new Stack<Task>();
            TaskStack.Push(new Task() { Details = "Brushing", Time = 10 });
            TaskStack.Push(new Task() { Details = "Washroom", Time = 20 });
            TaskStack.Push(new Task() { Details = "Getting ready for Office at", Time = 10 });
            TaskStack.Push(new Task() { Details = "Going to Office at", Time = 10 });
            Task tsk = TaskStack.Pop();
            System.Console.WriteLine("popped:{0} {1}", tsk.Details, tsk.Time);
            Task tk = TaskStack.Peek();
            System.Console.WriteLine($"peeked:{tk.Details} {tk.Time}");
            foreach (var items in TaskStack)
            {
                System.Console.WriteLine(items.Details + " " + items.Time);
            }
            //Non generic stack            
            Stack pop = new Stack();
            System.Console.WriteLine("enter the no of elements you want in stack");
            int length = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= length; i++)
            {
                var input = Console.ReadLine();
                pop.Push(input);
            }
            pop.Push("genre");
            foreach (var items in pop)
            {
                System.Console.WriteLine(items);
            }
            var pk = pop.Pop();
            System.Console.WriteLine($"poped element:{pk}");
        }
    }
}