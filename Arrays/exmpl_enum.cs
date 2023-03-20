using System;

namespace evaluation
{
    enum WeekDays
    {
        Monday=1,

        Tuesday,Wednesday,Thursday,Friday,Saturday,

        Sunday=0

    };

    public class enums

    {

      public void numenum()

      {

        for(int i=0;i<7;i++)

        {

            System.Console.WriteLine("Day "+ (i+1) +" of Week = "+(WeekDays)i);

        }

      }  

    }

}