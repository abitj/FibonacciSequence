using System;

// C# program that iteratively solves Fibonacci 

namespace FibonacciSequence

{
    public static class FibonacciSequence
    {
        public static void Main(string[] args)
        {//
            //Defines variables
            int firstNumber = 0, secondNumber = 1, thirdNumber, i, userNumber;
            //User Input
            Console.WriteLine();
            Console.Write("Enter the number of elements: ");
            userNumber = int.Parse(Console.ReadLine());

            //Prints 0 and 1
            Console.Write(firstNumber + " \n" + secondNumber + " \n");
            //Starts loop from 2 
            for (i = 2; i < userNumber; ++i)
            {
                thirdNumber = firstNumber + secondNumber;
                Console.Write(thirdNumber + " \n");
                firstNumber = secondNumber;
                secondNumber = thirdNumber;
            }
            //readability
            Console.Write("------------------------------------------------------------------\n");
        }
    }
}

