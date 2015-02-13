using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2CodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            // FizzBuzz call
            for (int i = 0; i < 21; i++)
            {
                Console.WriteLine(FizzBuzz(i));
            }
            // LetterCounter call
            LetterCounter('i', "I love biscuits and gravy. It’s the best breakfast ever.");
            LetterCounter('n', "Never gonna give you up. Never gonna let you down.");
            LetterCounter('s', "Sally sells seashells down by the seashore. She’s from Sussex.");



            // Cleans console
            Console.ReadKey();
        }

        /// <summary>
        /// FizzBuzz
        /// </summary>
        /// <param name="number">Number to check for FizzBuzzness</param>
        /// <returns>Fizz if can be divided by 5, Buzz if can be divided by 3, FizzBuzz if can be divided by 3 and 5, number if other</returns>
        public static string FizzBuzz(int number)
        {
            // can be divided by 3 and 5
            if ((number % 3 == 0) && (number % 5 == 0))
            {
                return "FizzBuzz";
            }
                // by 5
            else if (number % 5 == 0)
            {
                return "Fizz";
            }
                // by 3
            else if (number % 3 == 0)
            {
                return "Buzz";
            }

            return number.ToString();
        }
        /// <summary>
        /// Counts the number of upper and lower char letter in the string inString
        /// </summary>
        /// <param name="letter">Char to look for</param>
        /// <param name="inString">Sentence to search in</param>
        static void LetterCounter(char letter, string inString)
        {
            // Declaring of variables storing number of appearances
            int lowerCaseFound = 0;
            int upperCaseFound = 0;
            // Loop to search through the string
            for (int i = 0; i < inString.Length; i++)
            {
                if (inString[i] == Char.ToLower(letter))
                {
                    // Add one
                    lowerCaseFound++;
                }
                else if (inString[i] == Char.ToUpper(letter))
                {
                    // Add one
                    upperCaseFound++;
                }
            }
            // Prints out stats
            Console.WriteLine("Input: " + inString);
            Console.WriteLine("Number of lowercase " + letter + "'s found: " + lowerCaseFound);
            Console.WriteLine("Number of UPPERCASE " + letter + "'s found: " + upperCaseFound);
            Console.WriteLine("Total Number " + letter + "'s found: " + (upperCaseFound + lowerCaseFound));
        }
    }
}
