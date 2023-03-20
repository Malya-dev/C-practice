
using System;
namespace evaluation6
{
    public delegate void CalculateRectangleDelegate(double length, double breadth);
    public class MultiCastDelegateExample
    {
        public void RectangleArea(double x, double y)
        {
            System.Console.WriteLine("Area of rectangle is:{0}", x * y);
        }

        public static void RectanglePerimeter(double a, double b)
        {
            System.Console.WriteLine("The Perimeter of the Rectangle is:{0}", 2 * (a + b));
        }


        static void Main(string[] args)
        {
            Console.ForegroundColor=ConsoleColor.DarkMagenta;
            System.Console.WriteLine("Enter the height:");
            double ln = Convert.ToDouble(Console.ReadLine());
            System.Console.WriteLine("Enter the Breadth:");
            double br = Convert.ToDouble(Console.ReadLine());


            MultiCastDelegateExample multi = new MultiCastDelegateExample();
            CalculateRectangleDelegate rect = multi.RectangleArea;
            rect += RectanglePerimeter;
            rect(ln,br);

            System.Console.WriteLine();
            rect(13.56, 23.63);
            System.Console.WriteLine();
            

            // Anonymous methods
            CalculateRectangleDelegate rect2 =delegate(double q,double z)
            {
                System.Console.WriteLine("Diagonal of the Rectangle is:{0}",Math.Sqrt((q*q)+(z*z)));
            };
            rect2.Invoke(ln,br);
            Console.ResetColor();

        }
    }
}
