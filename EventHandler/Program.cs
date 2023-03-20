using System;

namespace evaluation7
{
    //subscriber class
    class Program
    {
        static void Main(string[] args)
        {
            Program prgm = new Program();
            prgm.Handler();
        }  
        public void Handler()
        {
            //obj of Publisher class
            Publisher publisher = new Publisher();

            //handle the event or subscribe to the event
            publisher.myEvent += (sender, ex) =>
            {
                int c = ex.a + ex.b;
                Console.WriteLine(c);
            };
            System.Console.WriteLine("Addition:");
            publisher.RaiseEvent(this, 30, 40);
            publisher.RaiseEvent(this, 9, 69);
            publisher.RaiseEvent(this, 25, 01);
        }
    }
}
