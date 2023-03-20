using System;

 namespace evaluation7
 {
    public class Subscriber
    {
      private readonly Publisher publish;
      public Subscriber(Publisher publish)
      {
         this.publish=publish;
         publish.notify+=MySubscriber;
         publish.notify+=MySubscriber2;
      }
      public void MySubscriber(string msg)
      {
         System.Console.WriteLine("Welcome!! Check out my new topic on {0}. Hope you Enjoy it.",msg);
      }

      public void MySubscriber2(string str)
      {
         System.Console.WriteLine("{0} course is live now !! Say hello and start practicing",str);
      }
    }
 }