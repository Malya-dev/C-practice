namespace Bank
{
    public class enumclass{
    enum bankdays{
        Monday =1,
        Tuesday=2,
        Wednesday=3,
        Thursday=4,
        Friday=5,
        Saturday=0,
        Sunday=0,
    }
    
    int a=(int)bankdays.Monday;
    int b=(int)bankdays.Tuesday;
    int c=(int)bankdays.Wednesday;
    int d=(int)bankdays.Thursday;
    int e=(int)bankdays.Friday;
    int f=(int)bankdays.Saturday;
    int g=(int)bankdays.Sunday;

    public void activedays()
    {
        System.Console.WriteLine("monday {0}",a);
        System.Console.WriteLine("tuesday {0}",b);
        System.Console.WriteLine("wednesday {0}",c);
        System.Console.WriteLine("thursday {0}",d);
        System.Console.WriteLine("friday {0}",e);
        System.Console.WriteLine("saturday {0}",f);
        System.Console.WriteLine("sunday {0}",g);
        
        }
    }
}