using System;
using System.Dynamic;
namespace DynamicTypes
{
    public class Program
    {
        static void Main(string [] args)
        {
            dynamic x;
            x=3564;
            System.Console.WriteLine(x);
            x="deb";
            System.Console.WriteLine(x+x);
            
            dynamic student= new ExpandoObject();
            System.Console.WriteLine("enter name");
            student.name=Console.ReadLine();

            System.Console.WriteLine("enter roll");
            student.roll=Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("enter design marks");
            student.DesignAlgoMarks=Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("enter ai marks");
            student.AIMarks=Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("enter software marks");
            student.SoftwareEngineeringMArks=Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("total MArks of 3 subjects");
            student.TotalMarks=student.DesignAlgoMarks+student.AIMarks+student.SoftwareEngineeringMArks;
            System.Console.WriteLine(student.TotalMarks);

            dynamic football = new ExpandoObject();
            football.Team="Real Madrid club de Futbol";
            football.Manager="carlo Ancelotti";
            football.SquadMembers=35;

            football.Address=new ExpandoObject();
            football.Address.City="Madrid";
            football.Address.Country="Spain";
            
            foreach( var items in (IDictionary<string,object>)football)
            {
                System.Console.WriteLine((items.Key +":"+items.Value));
            }

        }
    }
}
