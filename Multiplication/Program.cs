using System;

namespace Multiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber;
            int secondNumber;
            int thirdNumber;
            int result;

            Console.Write("Please enter the First Number: ");
            firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Please enter the Second Number: ");
            secondNumber = int.Parse(Console.ReadLine());

            Console.Write("Please enter the Third Number: ");
            thirdNumber = int.Parse(Console.ReadLine());

            result = firstNumber * secondNumber * thirdNumber;
            Console.WriteLine($"The Result of Multiplying {firstNumber} by {secondNumber} by {thirdNumber} is {result}");
        }
    }
}
