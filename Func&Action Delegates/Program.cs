using System;

namespace Practice
{
    public class Program
    {
        public static string functest1()
        {
            return "debmalya";
        }
        static void Main()
        {
            Func<string> datetime=()=>DateTime.Now.ToString();
            System.Console.WriteLine(datetime());

            Func<int, string, double, object> funcAdd = (x, str, y) => (x + str + y);
            System.Console.WriteLine(funcAdd(36, "pop", 8));
            System.Console.WriteLine(funcAdd(7, "position", 36.96));

            string str=functest1();
            System.Console.WriteLine(str);
            // Tuple inside func
            Func<(int, int), (int, int), (int, int)> funcTuple = (x, y) =>
            {
                return (x.Item1 * y.Item1, x.Item2 * y.Item2);
            };

            System.Console.WriteLine(funcTuple((3, 4), (5, 5)));

            //Factorial 
            Func<int, int> fct = (n) =>
            {
                int res = 1;
                while (n > 0 && n != 1)
                {
                    res = res * n;
                    n--;
                }
                return res;
            };
            System.Console.WriteLine("Enter a Number for Factorial");
            int x = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("The Factorial of {0} is: {1}", x, fct(x));

            // Action
            Action<int, int> actionAdd = (x, y) =>
            {
                System.Console.WriteLine("Summation of two numbers is {0}", (x + y));
            };
            actionAdd(96, 69);

            Dictionary<int, string> dict2 = new Dictionary<int, string>();
            System.Console.WriteLine("Enter the key and value:");
            System.Console.WriteLine("Enter key as zero and value as stop to Exit");
            
            while(true)
            {
                System.Console.WriteLine("KEY:");
                var k = Convert.ToInt32(Console.ReadLine());
                System.Console.WriteLine("VALUE:");
                string? v = Console.ReadLine();
                if( k.Equals(00) || v=="stop")
                    break;
                else
                    dict2.Add(k, v);
            }

            Action<Dictionary<int, string>> action = (b) =>
            {
                Dictionary<int, string> dict = new Dictionary<int, string>();
                System.Console.WriteLine("The keys and values pairs are:");
                foreach (var items in dict2)
                {
                    System.Console.WriteLine("key:{0} , Value:{1}", items.Key, items.Value);
                }

            };
            action.Invoke(dict2);

        }
    }
}