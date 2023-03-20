namespace Conditional;

public class Demo
{
    double num1;
    double num2;
    public void Calculator()

    {

        double result = 0;

        int cont;

        do

        {
            System.Console.WriteLine("Calculator");
            System.Console.WriteLine("-----------");

            System.Console.WriteLine("Enter 1 for Addition, \n2 for Subtraction, \n3 for Multiplication, \n4 for Division");

            int ch = Convert.ToInt16(Console.ReadLine());

            switch (ch)

            {

                case 1:

                    double sum = 0;

                    double j;

                    Console.WriteLine("How many Numbers do you want to Enter: ");

                    int n = Convert.ToInt32(Console.ReadLine());

                    System.Console.WriteLine("Enter Values: ");

                    for (int i = 0; i < n; i++)

                    {

                        j = Convert.ToDouble(Console.ReadLine());

                        sum += j;

                    }

                    System.Console.WriteLine("Sum = {0}", sum);

                    break;

                case 2:

                    Console.WriteLine("Enter Two values: ");

                    num1 = Convert.ToDouble(Console.ReadLine());

                    num2 = Convert.ToDouble(Console.ReadLine());

                    result = num1 - num2;

                    Console.WriteLine("Difference : {0}", result);

                    break;

                case 3:

                    double mult = 1;

                    Console.WriteLine("How many Numbers do you want to Enter: ");

                    n = Convert.ToInt32(Console.ReadLine());

                    System.Console.WriteLine("Enter Values: ");

                    for (int i = 0; i < n; i++)

                    {

                        j = Convert.ToDouble(Console.ReadLine());

                        mult *= j;

                    }

                    System.Console.WriteLine("Multiplication = {0}", mult);

                    break;

                case 4:

                    Console.WriteLine("Enter Two values: ");

                    num1 = Convert.ToDouble(Console.ReadLine());

                    num2 = Convert.ToDouble(Console.ReadLine());

                    if (num2 == 0)

                        throw new Exception("Cannot be divided by zero");
                        
                    else

                    {

                        result = num1 / num2;

                        Console.WriteLine("Division : {0}", result);

                    }

                    break;

                default:

                    System.Console.WriteLine("Invalid Selection");

                    break;

            }

            System.Console.WriteLine("Wish to continue? \nEnter 0 to continue,\nelse press any other number to exit");

            cont = Convert.ToInt16(Console.ReadLine());

        } while (cont == 0);

    }

}
