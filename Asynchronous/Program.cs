using System;
namespace AsyncProcess
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor=ConsoleColor.DarkMagenta;
            Method1();

            Method2();
            
            Console.ReadKey();
            Console.ResetColor();
        }
        public static async Task Method1()
        {
            await Task.Run(() =>{
            for(int i=0;i<=10;i++)
            {
                Task.Delay(1000).Wait();
                System.Console.WriteLine(@"Cristiano Ronaldo: ""I am The Greatest Of All Time");
            }
            });
        }
        public static async Task Method2()
        {
            await Task.Run(() =>{
            for(int i=0;i<10;i++)
            {
                Task.Delay(999).Wait();
                System.Console.WriteLine("Hahahaha!! Nice Joke!");
            }
        });
        }
    }
}