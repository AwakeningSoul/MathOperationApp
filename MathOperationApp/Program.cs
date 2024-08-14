using System;

namespace MathOperationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the MathOperations class
            MathOperations mathOps = new MathOperations();

            // Call the PerformOperation method, passing in two numbers
            mathOps.PerformOperation(5, 20);

            // Call the PerformOperation method again, specifying the parameters by name
            mathOps.PerformOperation(firstNumber: 8, secondNumber: 40);

            Console.ReadLine();
        }
    }
}
