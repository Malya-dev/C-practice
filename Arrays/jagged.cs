namespace evaluation
{
    public class Jagged
    {
        public void jarray()
        {
            System.Console.WriteLine("Enter the number of rows");
            int n=Convert.ToInt32(System.Console.ReadLine());
            
            int [][] arr=new int [n][];
            for(int i=0;i<arr.Length;i++)
            {
                System.Console.WriteLine("Enter the coloumns in {0}th row:",(i+1));

                int x=Convert.ToInt32(Console.ReadLine());
                arr[i]=new int[x];

                System.Console.WriteLine("Enter the digits of the array");
                for(int j=0;j<x;j++)
                {
                    arr[i][j]=Convert.ToInt32(Console.ReadLine());
                }

            }

            Console.ForegroundColor=ConsoleColor.Magenta;
            System.Console.WriteLine();
            System.Console.WriteLine("The Matrix is:");

            for(int i=0;i<arr.Length;i++)
            {
                for(int j=0;j<arr[i].Length;j++)
                {
                    System.Console.Write(arr[i][j]+" ");
                }
                System.Console.WriteLine(" ");
            }
            Console.ResetColor();
        }
    }
}