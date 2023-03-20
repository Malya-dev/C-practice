using System;
using System.Collections;
using System.Collections.Generic;

namespace DictionaryExamples
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            System.Console.WriteLine("--- REAL MADRID CLUB DE' FOOTBALL --- \nThe Dream of other Clubs");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            System.Console.WriteLine("--- DREAM SQUAD ---");
            Dictionary<int, string> MySquad = new Dictionary<int, string>
            {
                {7,"Cristiano Ronaldo"},
                {10,"Luka Modric"},
                {8,"Mesut Ozil"},
                {9,"Karim Benzema"},
                {4,"Sergio Ramos"},
                {1,"Thibout Courtois"},
            };

            // Adding element in the dictionary
            MySquad.Add(11, "Angel Di Maria");

            foreach (var items in MySquad)
            {
                System.Console.WriteLine("Jersey Number: {0} Player: {1}", items.Key, items.Value);
            }

            // Entering element in dictionary using user input
            System.Console.WriteLine("Enter the new Jersey Number");
            int JerseyNumber=Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Enter the Player Name");
            string ?PlayerName=Console.ReadLine();

            // if(JerseyNumber<1 & JerseyNumber>1000)
            // {
            //     throw new Exception("Cannot be zero or Greater than Thousand"); 
            // }
            // if(PlayerName is null)
            // {
            //     throw new Exception("player name cannot be null");
            // }

            MySquad.Add(JerseyNumber,PlayerName);

            foreach (var items in MySquad)
            {
                System.Console.WriteLine("Jersey Number: {0} Player: {1}", items.Key, items.Value);
            }
            
            Console.ResetColor();
        }
    }
}