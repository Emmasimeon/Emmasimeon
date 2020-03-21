using System;

namespace Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber;
            int secondNumber;
            int result;

            Console.Write("Please enter the first number: ");
            firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Please enter the second number/divisor: ");
            secondNumber = int.Parse(Console.ReadLine());

            //divide the first number by the second number and
            //save the result to the variable result.
            result = firstNumber / secondNumber;

            Console.WriteLine($"The result is {result}");
        }
    }
}
