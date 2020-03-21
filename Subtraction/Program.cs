using System;

namespace Subtraction
{
    class Program
    {
        static void Main(string[] args)
        {
           //declaring the variables to be used by the program.
           int firstNumber;
           int secondNumber;
           int result;


            //Request for the user to enter the first number
           Console.Write("Please enter the first/base number: ");
            //Capture the user input value and store to the variable firstNumber
           firstNumber = int.Parse(Console.ReadLine());

            //Request for the user to enter the second number
           Console.Write("Please enter the second number/number to be subtracted: ");
            //Capture the user input value and store to the variable secondNumber
           secondNumber = int.Parse(Console.ReadLine());

            // Subtrack the value of the second number from the first number and
            // save the result to the result variable.
           result = firstNumber - secondNumber;

           //Display the result value to the console
           Console.WriteLine($"The result is {result}");
        }
    }
}
