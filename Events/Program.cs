using System;

 namespace evaluation7
 {
    public class Program
    {
        static void Main(string[] args)
        {
            Publisher publish=new Publisher();

            Subscriber subscribe=new Subscriber(publish);

            Subscriber2 subscribe2=new Subscriber2(publish);

            // publish.notify+=subscribe.MySubscriber;
            // publish.notify+=subscribe.MySubscriber2;
            // publish.notify+=subscribe2.MySubscriber3;
            
            Console.ForegroundColor=ConsoleColor.Green;
            publish.RaiseEvent("Visual Basics");
            System.Console.WriteLine();
            publish.RaiseEvent("F#");
            System.Console.WriteLine();
            publish.RaiseEvent("Python");
            Console.ResetColor();


        }
    }
 }