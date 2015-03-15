using System;
using System.Collections.Generic;
using System.Linq;

namespace Week3CodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindNPrimes(6));
            Console.WriteLine(EvenFibonacciSequencer(20));
            Console.WriteLine(LongestCollatzSequence());
            Console.ReadKey();
        }
        /// <summary>
        /// A function that calculates the starting value of the longest Collatz sequence.
        /// This function will start at 1 million and look at which value generates the
        /// longest sequence.
        /// </summary>
        /// <returns>Starting value of the longest sequence</returns>
        public static long LongestCollatzSequence()
        {
            // Number holding temporary results
            long currentNumber = 0;
            // How many number is in sequence
            long sequenceCount = 0;
            // Longest sequence
            long sequenceCountLongest = 0;
            // Number with longest sequence
            long collatzBest = 0;
            // Looping up to 1000000
            for (int i = 1; i < 1000000; i++)
            {
                sequenceCount = 0;
                currentNumber = i;
                // Until reaches 1
                while (currentNumber != 1)
                {
                // For even
                if (currentNumber % 2 == 0)
                {
                    currentNumber = currentNumber / 2;
                }
                // For odd
                else
                {
                    currentNumber = 3 * currentNumber + 1;
                }
                sequenceCount++;
                }
                // If it's the longest one
                if (sequenceCountLongest < sequenceCount)
                {
                    sequenceCountLongest = sequenceCount;
                    collatzBest = i;
                }
            }
            return collatzBest; // Default return value, replace this
        }

        /// <summary>
        /// A Function that adds up each even number in a Fibonacci Sequence until the maxValue
        /// then prints the sum of those numbers to the console
        /// </summary>
        /// <param name="maxValue"></param>
        /// <returns>The sum of every even number for the given number of Fibonacci digits</returns>
        public static long EvenFibonacciSequencer(long maxValue)
        {
            // Numbers to start with
            int numberOne = 1;
            int numberTwo = 2;
            // Temporary sum for adding of two number
            int tempSum = 0;
            // Final sum of even tempSums to compare with maxValue
            int finalSum = 2;
            // Until we reach maxValue
            while (tempSum < maxValue)
            {
                // Temporary sums
                tempSum = numberOne + numberTwo;
                // If even
                if (tempSum % 2 == 0)
                {
                    finalSum += tempSum;
                }
                // Switch numbers further
                numberOne = numberTwo;
                numberTwo = tempSum;
            }
            return finalSum;
        }

        /// <summary>
        /// Function that finds the n'th prime indicated by the parameter
        /// </summary>
        /// <param name="maxPrime"></param>
        /// <returns>The prime number which is the n'th found</returns>
        public static int FindNPrimes(int maxPrime)
        {
            // Counter for prime numbers
            int primeNumberCounter = 0;
            // Number to check
            int currentNumber = 2;
            // Boolean if number is prime
            bool isPrime = true;
            // Until we reach number of prime numbers needed
            while (primeNumberCounter < maxPrime)
            {
                // Check if can be divided without reminder
                for (int i = 2; i < currentNumber; i++)
                {
                    if (currentNumber % i == 0)
                    {
                        isPrime = false;
                        break;
                    } 
                    isPrime = true;
                }
                if (isPrime)
                {
                    // Increase counter
                    primeNumberCounter++;
                }
                // Next number to check
                currentNumber++;
            }
            return currentNumber - 1;
        }
    }
}
