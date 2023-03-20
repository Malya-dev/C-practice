// using System;
// namespace evaluation6
// {
//     class Program
//     {
//         public delegate void DelegateMethod(string msg);
//         public void callback(string msg)
//         {
//             System.Console.WriteLine(msg);
//         }

      
//         public static void TestMethod(string msg)
//         {
//             System.Console.WriteLine(msg);
//             for(int i=1;i<=100;i++)
//             {
//                 System.Console.WriteLine(i);
//             }
//         }

//         public static void Main(string[] args)
//         {
//             Console.ForegroundColor=ConsoleColor.DarkYellow;
//             Program obj = new Program();
//             DelegateMethod del1=new DelegateMethod(obj.callback);
//             // DelegateMethod del2=new DelegateMethod(obj.TestMethod);

//             // string str=System.Console.ReadLine();
           
//             del1("Hello Im called");
//             del1+=TestMethod; //static method

//             del1.Invoke("Printing from one to hundred.");

//             // del2.Invoke("1 to 100");
//             Console.ResetColor();

//         }
//     }
// }