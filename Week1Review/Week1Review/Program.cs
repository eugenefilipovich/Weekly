using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1Review
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberRounder(5768);

            SpecificLetterCounter("s", "Sally is sunny and super special");

            SpaceRemover("A cat is a nice pet");

            Console.WriteLine(AnnoyingTextifyer("Nickelback"));

            // A built in space remover
            string noSpaces = " lots of spaces ".Replace(" ", "");


            Console.ReadKey();
        }
        /// <summary>
        /// Takes in a strinhg, removes all the spaces
        /// </summary>
        /// <param name="inputString">String to despacify</param>
        /// <returns>A string with no spaces</returns>
        static string SpaceRemover(string inputString)
        {
            // Declare empty return string
            string returnString = string.Empty;

            for (int i = 0; i < inputString.Length; i++)
            {
                // Get an individual letter
                string letter = inputString[i].ToString();
                if (letter != " ")
                {
                    // Letter is not a space
                    returnString = returnString + letter;
                }
            }
            // Loop complete, return our return string
            return returnString;
        }
        /// <summary>
        /// Counts the number of instances of a specific letter in a string
        /// </summary>
        /// <param name="letterToCount">Letter to count</param>
        /// <param name="stringToSearch">String to search</param>
        static void SpecificLetterCounter(string letterToCount, string stringToSearch)
        {
            // Number of hits
            int count = 0;
            for (int i = 0; i < stringToSearch.Length; i++)
            {
                // Comparing letters
                if (stringToSearch[i].ToString().ToLower() == letterToCount)
                {
                   count = count + 1;
                }
            }
            // Or Console.WriteLine(" {0} has {1} {2}'s in it", stringToSearch, count, letterToCount);
            Console.WriteLine(stringToSearch + " has " + count + " " + letterToCount);
        }
        // Input is 7, output 5.
        /// <summary>
        /// NumberRounder, rounds an integer to the nearest 5
        /// </summary>
        /// <param name="numberToRound"></param>
        /// <returns></returns>
        static int NumberRounder(int numberToRound)
        {
            int remainder = numberToRound % 5;
            if (remainder > 2)
            {
                return (numberToRound - remainder + 5);
            }
            else
            {
                return (numberToRound - remainder);
            }
        }
        /// <summary>
        /// Take a string, it will return a string with letters alteration between upper and lower case.
        /// </summary>
        /// <param name="notAnnoyingString">String to make annoying</param>
        /// <returns>Hard to read string</returns>
        static string AnnoyingTextifyer(string notAnnoyingString)
        {
            // Output string
            string returnString = string.Empty;

            for (int i = 0; i < notAnnoyingString.Length; i++)
            {
                // Get a letter to examine
                string currentLetter = notAnnoyingString[i].ToString();

                // If the position is odd or even
                if (i % 2 == 0)
                {
                    returnString += currentLetter.ToUpper();
                }
                else
                {
                    returnString += currentLetter.ToLower();
                }
            }
            return returnString;
        }
    }
}
