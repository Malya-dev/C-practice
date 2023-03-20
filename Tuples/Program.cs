using System;
namespace practice
{
    public class Customer
    {
        // value tuples
        public (double CustomerPhoneNumber, int CustomerID, string CustomerName) GetCustomerDetails()
        {
            return (9163907894, 70069, "Usnish Ghosh");
        }
    }
    
    public class Program
    {
         // Tuple Method
        public static Tuple<int, int, int> Cubes((int a, int b, int c) cb)
            {
                int a = cb.Item1; int b = cb.Item2; int c = cb.Item3;
                return new Tuple<int, int, int>(a * a * a, b * b * b, c * c * c);
            }
        static void Main()
        {
            // Normal Tuples
            Tuple<double, int, string> student = new Tuple<double, int, string>(7.69, 10, "physics");
            System.Console.WriteLine("student details");
            System.Console.WriteLine("class:{0}" , student.Item1);
            System.Console.WriteLine("RollNo:{0}" , student.Item2);
            System.Console.WriteLine("subject:{0}" , student.Item3);
            System.Console.WriteLine();

            System.Console.WriteLine("customer details:");

            Customer customer = new Customer();
            // deconstructing
            (double CustomerPhoneNumber, int CustomerID, string CustomerName) = customer.GetCustomerDetails();
            System.Console.WriteLine(CustomerPhoneNumber);
            System.Console.WriteLine(CustomerID);
            System.Console.WriteLine(CustomerName);

            System.Console.WriteLine();

            System.Console.WriteLine("The cube is:"+Cubes((2,5,3)));

            // taking user input in tuples
            System.Console.WriteLine("Give input in tuple");
            int id=Convert.ToInt32(Console.ReadLine());
            string? name=Console.ReadLine();
            int roll=Convert.ToInt32(Console.ReadLine());
            string? subject=Console.ReadLine();
            Tuple<int,string,int,string> ioInput= new Tuple<int, string, int, string>(id,name,roll,subject);
            System.Console.WriteLine(ioInput);
        }
    }
}

