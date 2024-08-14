using System;
using System.Collections.Generic;
using System.Text;

namespace MathOperationApp
{
    class MathOperations
    {
        // Create a void method named PerformOperation that takes two integers as parameters
        public void PerformOperation(int firstNumber, int secondNumber)
        {
            // Perform a math operation on the first integer (e.g., add 10 to it)
            int result = firstNumber + 10;

            // Display the second integer to the console
            Console.WriteLine("The second integer is: " + secondNumber);

            // Display the result of the operation
            Console.WriteLine("The result of the operation on the first integer is: " + result);
        }
    }
}
