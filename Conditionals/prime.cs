namespace Conditional
{
    public class PrimeNUmbers
    {
        public void prime()
        {
            System.Console.WriteLine("Enter the range of prime numbers you want to print");
            int n=Convert.ToInt32(System.Console.ReadLine());
            int i = 0;
            int j = 0;
            int flag = 0;

            for (i = 2; i <= n; i++)
            {
                j = 2;
                flag = 0;
                while (j <= (i / 2))
                {
                    if (i % j == 0)
                    {
                        flag = 1;
                        break;
                    }
                    j++;
                }

                if (flag == 0)
                    Console.Write(i + " ");

            }
            Console.WriteLine();
        }
    }
}