namespace Conditional
{
    public class reverse
    {
        public void rvrs()
        {
            System.Console.WriteLine("enter the number you want to reverse");
            int a = Convert.ToInt32(Console.ReadLine()), rev = 0, b;


            while (a != 0)
            {
                b = a % 10;
                rev = (rev * 10) + b;
                a = a / 10;
            }
            Console.WriteLine("The reverse of the number is: " + rev);
        }
    }
}