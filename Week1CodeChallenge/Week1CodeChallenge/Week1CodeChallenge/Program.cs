using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1CodeChallenge
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
            for (int i = 92; i > 78; i--)
            {
                Console.WriteLine(FizzBuzz(i));
            }
            // Yodaizer call
            Console.WriteLine(Yodaizer("I like code"));
            // Text stats call
            TextStats("You stand on dead men's legs. You've never had any of your own. You couldn't walk alone between two sunrises and hustle the meat for your belly");
            // IsPrime call
            // Each odd number goes to IsPrime
            for (int i = 1; i <= 25; i = i + 2)
			{
                // If true, number is prime
                if (IsPrime(i))
                {
                    Console.WriteLine(i + " is a prime number");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            // DashInsert call
            Console.WriteLine(DashInsert(454793));
            Console.WriteLine(DashInsert(8675309));
           
            
            // Console open
            Console.ReadKey();
        }
        /// <summary>
        /// FizzBuzz
        /// </summary>
        /// <param name="number">Number to check for FizzBuzzness</param>
        /// <returns>Fizz if can be divided by 5, Buzz if can be divided by 3, FizzBuzz if can be divided by 3 and 5, number if other</returns>
        public static string FizzBuzz(int number)
        {
            if ((number % 3 == 0) && (number % 5 == 0))
            {
                return "FizzBuzz";
            }
            else if (number % 5 == 0)
            {
                return "Fizz";
            }
            else if (number % 3 == 0)
            {
                return "Buzz";
            }

            return number.ToString();
        }
        /// <summary>
        /// Takes string and returns string with words in reversed order
        /// </summary>
        /// <param name="text">Text to manipulate</param>
        /// <returns>String reversed. Extra: Last word from the initial string goes first, then reversed string</returns>
        public static string Yodaizer(string text)
        {
            // Words go to an array of strings
            string[] splitStringArray = text.Split(new Char[] {' '});
            // String for output
            string returnString = string.Empty;
            // Extra condition
            if (splitStringArray.Length == 3)
            {
                // Adding last word in the main string to the start of the output string
                returnString = splitStringArray[splitStringArray.Length - 1].ToString() + ", ";
                // Loop to make output string (used loop in case we need to change number of words for extra condtition)
                for (int i = 0; i < splitStringArray.Length - 1; i++)
                {
                    returnString = returnString + splitStringArray[i].ToString() + " ";
                }
                return returnString.Substring(0, returnString.Length - 1).ToLower();
            }
                // Main condition
            else
            {
                // Loop to make output string 
                for (int i = splitStringArray.Length - 1; i >= 0; i--)
                {
                returnString = returnString + splitStringArray[i].ToString() + " ";
                }
                // Deleting space in the end. Can be used insted of Trim
            return returnString.Substring(0,returnString.Length - 1).ToLower();
            }
            
        }

        static void TextStats(string input)
        {
            // Number of characters found
            Console.WriteLine("Number of characters: " + input.Length);
            // Number of words in the string
            string[] splitInputArray = input.Split(new Char[] { ' ' });
            Console.WriteLine("Number of words: " + splitInputArray.Length);
            // Vowel counter
            int vowelsFound = 0;
            // Loop going through all indexes to compare each letter
            for (int i = 0; i < input.Length; i++)
            {
                // Pulling out individual letter and converting it to lower case
                char letter = char.ToLower(input[i]);

                // Is it a vowel? 
                if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
                {
                    // Counting
                    vowelsFound = vowelsFound + 1;
                }
            }
            Console.WriteLine("Number of vowels: " + vowelsFound);
            // Consonants counter
            int consonantsFound = input.Count(c => "qwrtypsdfghjklzxcvbnm".Contains(Char.ToLower(c)));
            Console.WriteLine("Number of consonants: " + consonantsFound);
            // Special characters counter
            int specialCharsFound = 0;
            // Create a list of characters:
            var specialCharacters = new HashSet<char> {' ', '.', ',', '!', '?', ';', ':', '@', '#', '$', '%'};
            // Loop going through all indexes to compare each letter
            for (int i = 0; i < input.Length; i++)
            {
                if (specialCharacters.Contains(input[i]))
                {
                    specialCharsFound++;
                }
            }
            Console.WriteLine("Number of special characters: " + specialCharsFound);
            // Extra:
            // Sorts array of strings in ascending order
            Array.Sort(splitInputArray, (x, y) => y.Length.CompareTo(x.Length));
                Console.WriteLine("Longest word: " + splitInputArray[0]);
            // If we have more than one words of maximum length we need that loop to find secondf largest word in the list
            int counter = 0;
                while (splitInputArray[counter].Length == splitInputArray[counter + 1].Length)
                {
                    counter++;
                }
                Console.WriteLine("Second longest word: " + splitInputArray[counter + 1]);
                Console.WriteLine("Shortest word: " + splitInputArray[splitInputArray.Length - 1]); 

            

        }
        /// <summary>
        /// Checks if input is a prime number
        /// </summary>
        /// <param name="number">Number to check</param>
        /// <returns>True or false</returns>
        public static bool IsPrime(int number)
        {
            // If divided without leftover only twice then the number is prime, else not a prime number
            int numberOfHits = 0;
            // Dividing by all numbers from 1 to input number
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    numberOfHits++;
                }
            }
            // Checking of numberOfHits
            if (numberOfHits <= 2)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
        public static string DashInsert(int number)
        {
            // String for console
            string numberStringOutput = string.Empty;
            // String for input number converted to string
            string numberString = number.ToString();
            // Counter for while loop
            int counterWhile = 0;
            // Loop to search for 2 odd numbers standing one rigth after each other
            while (counterWhile < numberString.Length - 1)
            {
                // Condition for 2 odd numbers
                if (numberString[counterWhile] % 2 != 0 && numberString[counterWhile + 1] % 2 != 0)
                    {
                        // Adding to output string
                        numberStringOutput = numberStringOutput + numberString[counterWhile].ToString() + "-";
                        counterWhile = counterWhile + 1;
                    }
                    else
                    {
                        // Adding to output string
                        numberStringOutput = numberStringOutput + numberString[counterWhile].ToString();
                        counterWhile = counterWhile + 1;
                    }
                
            }
            return numberStringOutput + numberString[numberString.Length - 1].ToString();
        }
    }
}
