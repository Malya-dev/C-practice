namespace evaluation
{
    public class delete_array
    {
        public void del()
        {
            int pos, size;
            System.Console.WriteLine("Enter the size of array");
            size = Convert.ToInt32(System.Console.ReadLine());

            System.Console.WriteLine("Enter the elements of the array");

            var arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = Convert.ToInt32(System.Console.ReadLine());
            }

            Console.Write("Enter the position where to delete: ");
            pos = Convert.ToInt32(Console.ReadLine());
            
            if(pos>=size+1)
            {
                System.Console.WriteLine("Deletion not possible");
            }
            else{
                for(int i=pos-1; i<size-1;i++)
                {
                    arr[i]=arr[i+1];
                }
                System.Console.WriteLine("The resultant array is:");
                for(int i=0; i<size-1;i++)
                {
                    System.Console.WriteLine(arr[i]);
                }
            }

        }

    }
}