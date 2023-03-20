using System;
using System.Collections.Generic;
using System.Collections;

namespace ArraylistExamples
{
    class Sample
    {
        public Employee GetEmployee()
        {
            return new Employee(){EmployeeName="Debmalya"};
        }
    }
    class Employee{
        public string ?EmployeeName{get;set;}
    }
    public class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrlist=new ArrayList(){99,"Lion",3.69,'x'};
            arrlist.Add("hello");
            arrlist.Add(101);
            arrlist.Reverse();
            int pos=arrlist.IndexOf(99);
            System.Console.WriteLine(pos);
            Sample samp=new Sample();
            arrlist.Add(samp.GetEmployee);
            foreach(var items in arrlist)
            {
                if(items is Employee emply)
                System.Console.WriteLine(emply.EmployeeName);
                else
                System.Console.WriteLine(items);
            }
        }
    }
}