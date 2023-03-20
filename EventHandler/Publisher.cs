using System;

namespace evaluation7
{
    //child class of EventArgs
    public class AdditionEventArgs: EventArgs
    {
        public int a { get; set; }
        public int b { get; set; }
    }
    public class Publisher
    {
        //creating event
        public event EventHandler<AdditionEventArgs> ?myEvent;

        public void RaiseEvent(object sender, int a, int b)
        {
            //Raising event
            if (this.myEvent != null)
            {
                AdditionEventArgs addevent = new AdditionEventArgs() { a = a, b = b };
                this.myEvent(sender, addevent);
            }
        }
    }
}
