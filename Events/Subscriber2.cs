using System;

 namespace evaluation7
 {
    public class Subscriber2
    {
        private readonly Publisher publish;
        public Subscriber2(Publisher publish)
        {
            this.publish=publish;
            publish.notify+=MySubscriber3;
            
        }
      public void MySubscriber3(string msg)
      {
         System.Console.WriteLine("We are at the End of this {0} course.",msg);
      }
    }
 }
