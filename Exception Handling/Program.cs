using System;

namespace ExceptionExamples
{
    class InsufficientNumbersException: InvalidOperationException
    {
        public override string Message
        {
            get
            {
                return "Insufficient number";
            }
        }
    }
    class DivideByOddEception : ApplicationException
    {
        public override string Message
        {
            get
            {
                return "Attempted To Divide BY Odd Number";
            }
        }
    }
    public class Program
    {

        static void Main(string[] args)
        {

            int num1, num2, result;
            try
            {
                System.Console.WriteLine("Enter The index of the array");
                int position = Convert.ToInt32(Console.ReadLine());
                int[] arr = new int[] { 25, 36, 69, 58, 74, 10, 25 };
                System.Console.WriteLine(arr[position]);

                System.Console.WriteLine("Enter a number");
                num1 = Convert.ToInt32(Console.ReadLine());
                System.Console.WriteLine("Enter another number");
                num2 = Convert.ToInt32(Console.ReadLine());
                if (num1 ==0 && num2==0)
                {
                    throw new InsufficientNumbersException();
                }
                if (num2 % 2 != 0)
                {
                    throw new DivideByOddEception();
                }
                result = num1 / num2;
                System.Console.WriteLine("Result after division is:");
                System.Console.WriteLine(result);
            }
            catch (IndexOutOfRangeException ex)
            {
                System.Console.WriteLine(ex.Message);
                System.Console.WriteLine(ex.Source);
                System.Console.WriteLine(ex.StackTrace);
            }
            catch(InsufficientNumbersException ex)
            {
                System.Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                System.Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                System.Console.WriteLine("Input must be Numeric.");
            }
            catch(NullReferenceException)
            {
                throw new ArgumentNullException("num1","its null");
            }
            
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
            finally
            {
                System.Console.WriteLine("Start practicing more.");
            }
        }
    }
}
