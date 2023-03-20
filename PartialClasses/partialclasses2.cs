using System;

namespace Evaluation6
{
    public partial class Debmalya
    {
    private double _basics;
    public double Basics
    {
        set{
            _basics=value;
        }
        get{
            return _basics;
        }
    }

    private string? _company;

    public string Company
    {
        set
        {
            _company=value;
        }
        get
        {
            return _company!;
        }
    }
    // public void CallGetSalary()
    // {
    //     System.Console.WriteLine("Your salary is :");
    //     GetSalary();
    // }

    }
}