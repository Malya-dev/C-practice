namespace evaluation
{
    public class arrmthds
    {
        public void methodarray()
        {
        //    Index of uses linear search to serach for an array
            double[] arr=new double[]{52,68,99,63,20.9,89,69.69,99,63};
            var n=Array.IndexOf(arr,99);
            System.Console.WriteLine(n);
            System.Console.WriteLine("second occurrance");
            var m=Array.IndexOf(arr,99,4);
            System.Console.WriteLine(m);

            //  binary search uses binary search so it is faster than indexof method
            //  it requires the array to  be pre sorted

            int[] ar=new int[]{9,10,69,165,269,777,969};
            var nm=Array.BinarySearch(ar,69);
            System.Console.WriteLine(nm);

            Array.Clear(ar,0,ar.Length);
            foreach(var rr in ar)
            {
                System.Console.WriteLine(rr);
            }


        }
    }
}

            
          