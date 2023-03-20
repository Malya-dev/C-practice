using System;
using System.Dynamic;
 namespace Anonymous
 {
    public  delegate void  CalculateFactorial(int x);
    public class Program
    {
        static void Main(string[] args)
        {
            var student=new {Name="DebMalya", RollNo=69, Class=12,Major="SCience",
                            Adress=new {City="kokata",Country="India",HouseNumber=356}};
            
            System.Console.WriteLine(student.Name);
            System.Console.WriteLine(student.Major);
            System.Console.WriteLine(student.Adress.City +" " + student.Adress.Country);

            

            System.Console.WriteLine("enter the number you want as factorial");
            var cont=new{ y=Convert.ToInt32(Console.ReadLine())};
           
            CalculateFactorial fact= delegate(int x)
            {
                int result=1;
                while(x>0 && x!=1)
                {
                    result= result*x;
                    x=x-1;
                }
                System.Console.WriteLine(result);
                
            };
            fact.Invoke(cont.y);

            // using the with keyword
            var NewStudent=student with {Name="she",RollNo=16,
                                        Adress=new {City="Pune",Country="India",HouseNumber=69}};
            System.Console.WriteLine(NewStudent.Name+" "+NewStudent.RollNo+" "+
                                    NewStudent.Adress.City+" "+NewStudent.Adress.Country+" "+NewStudent.Adress.HouseNumber);

            // anonymous array
            var AnonSingerArray= new[] {new {Title="rock",Track=4}, new{Title="pop",Track=3}, 
                                        new{Title="sad",Track=2}};
            foreach( var items in AnonSingerArray)
            {
                System.Console.WriteLine(items.Title+" "+items.Track);
            }

            try{
            System.Console.WriteLine(AnonSingerArray[20].Title + " " + AnonSingerArray[0].Track);
            }
            catch(Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
             var Sing=new{song="opera",title=7};
             System.Console.WriteLine(Sing.ToString());
        }
    }
 }