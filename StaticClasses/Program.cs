using System;
namespace Evaluation6
{
    static class Myclass
    {
        // int NumberOfContinents=22; Cannot be declared without static
        public static string Continent = "ASIA";
        public static string country = "India";
        public static int states = 29;

        public static int ReturnReligions()
        {
            return 1 * states;
        }
        static Myclass()
        {
            int v=36, x=63;
            System.Console.WriteLine("This is a constructor at {0}",+x);
            System.Console.WriteLine("I am running again at {0}",+v);
        }

        static void Main(string[] args)
        {
            System.Console.WriteLine(Continent);
            System.Console.WriteLine((ReturnReligions()));
            System.Console.WriteLine(country);
            System.Console.WriteLine("{0} got {1} states.", Myclass.country, Myclass.states);
            System.Console.WriteLine();
        }
    }
}