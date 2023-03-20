namespace evaluation
{
    public class multidimension
    {
        public void twodarray()
        {
            System.Console.WriteLine("Enter the number of rows");
            int n=Convert.ToInt32(System.Console.ReadLine());

            System.Console.WriteLine("Enter the number of coloumns");
            int m=Convert.ToInt32(System.Console.ReadLine());

            System.Console.WriteLine("enter the elements");
            
            int[,] arr =new int[n,m];
            for(int i=0;i<n;i++)
            {
                for(int j=0;j<m;j++)
                {
                    arr[i,j]=Convert.ToInt32(System.Console.ReadLine());
                }
            }
            System.Console.WriteLine("show the matrix");
            for(int i=0;i<n;i++)
            {
                for(int j=0;j<m;j++)
                {
                    System.Console.Write(arr[i,j]+" ");
                }
                System.Console.WriteLine("");
            }
        }
    }
}
