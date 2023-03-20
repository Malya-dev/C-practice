using System;

 namespace evaluation7
 {
   public delegate void MyDelegateType(string msg);
    public class Publisher
    {
      private MyDelegateType ?myDelegate;

      public event MyDelegateType notify
      {
         add
         {
            myDelegate+=value;
         }
         remove
         {
            myDelegate-=value;
         }
      }
      
      // public void Msg(string m)
      // {
      //    System.Console.WriteLine(m);
      // }
      public void RaiseEvent(string str)
      {
         if(this.myDelegate!=null)
            this.myDelegate(str);

            // this.myDelegate(mn);
      }
      }
    }
 