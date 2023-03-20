namespace evaluation
{
    public class sumarray
    {
        public void summation()
        {
            System.Console.WriteLine("Enter the size of array");
            int size=Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine("Enter the elements of the array");
            var arr=new int[size];
            for(int i=0;i<size;i++)
            {
                arr[i]=Convert.ToInt32(System.Console.ReadLine());
            }
            int sum=0; 
            for(int i=0;i<size;i++)
            {
                sum+=arr[i];
            }
            System.Console.WriteLine("Sum of elements of the array is: {0}",sum);
        }
    }
}
