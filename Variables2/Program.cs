using System;

namespace Variables2
{
    class Program
    {
        static void Main(string[] args)
        {
        
            int firstNumber = 0;
            int secondNumber = 0;
            int result;

            Console.Write("Please enter the first Number: ");
            firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Please enter the second Number: ");
            secondNumber = int.Parse(Console.ReadLine());

            result = firstNumber + secondNumber;

            Console.WriteLine($"The answer is {result}");


        }
    }
}
