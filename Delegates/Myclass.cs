// namespace evaluation6
// {
//     public class MyClass
//     {
//         public delegate void CallBack(int i);
//         public void LongRunning(CallBack obj)
//         {
//             for(int i=0;i<1000;i++)
//             {
//                 if(i==500){
//                     System.Console.WriteLine("i am looping at loop number");
//                     obj(i);
//                 }
//             }
//         }
//         static void callback(int i)
//         {
//             System.Console.WriteLine(i);
//         }
//         public static void Main(string[] args)
//         {
//             MyClass obj=new MyClass();
//             obj.LongRunning(callback);
//         }
//     }
// }