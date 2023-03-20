namespace evaluation
{
    public class reverse
    {

        public void rev()
        {
            System.Console.WriteLine("Enter the size of array");
            int size=Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine("Enter the elements of the array");
            var arr=new int[size];
            for(int i=0;i<size;i++)
            {
                arr[i]=Convert.ToInt32(System.Console.ReadLine());
            }
            System.Console.WriteLine("The elements in correct order is:");
            foreach(var items in arr)
            {
                System.Console.WriteLine(items);
            }
            System.Console.WriteLine("The elements in the Reverse order is:");
            for(int i=arr.Length-1;i>=0;i--)
            {
                System.Console.WriteLine(arr[i]);
            }
        }
    }
}