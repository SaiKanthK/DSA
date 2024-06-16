using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Algorithms.Strings
{
    public class WordFrequency
    {
        public static void Main()
        {

            int result = WordFrequency("The quick brown fox jumps over the lazy dog", "the");//Finding a word multiple times (expects 2)
            Console.WriteLine(result);
            result = WordFrequency("The quick brown fox jumps over the lazy dog", "cat")//Finding a non-existent word (expects 0)
            Console.WriteLine(result);
            result = WordFrequency("This is a TEST", "Test");// Case insensitive test
            Console.WriteLine(result);
            result = WordFrequency("This      string has multiple spaces", "string"); // Handles multiple spaces
            Console.WriteLine(result);

        }


        /// <summary>
        /// This function calculates the frequency of a given word/character within a string.
        /// </summary>
        /// <param name="wholePhrase">The string to search within.</param>
        /// <param name="word">The word to search for.</param>
        /// <returns>The number of times the word appears in the string, or 0 if not found.</returns>
        public static int WordFrequency(string wholePhrase, string wordToSearch)
        {
            int whole_Length = wholePhrase.Length;
            int word_Length = wordToSearch.Length;

            // Remove all occurrences of the word (in lowercase) from the lowercase phrase
            // and calculate the length of the resulting string.
            // This effectively counts the number of times the word appeared in the original phrase
            // by finding the difference in lengths.
            // Calculate the frequency by dividing the original phrase length by the word length
            // and subtracting the new length (without the word) from that value.
            int result = (whole_Length - wholePhrase.ToLower().ToLower().Replace(wordToSearch.ToLower(), String.Empty).Length) / word_Length;

            return result;
        }
    }
}