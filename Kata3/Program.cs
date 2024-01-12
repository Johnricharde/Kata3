using Microsoft.VisualBasic;
using System.ComponentModel;
using System.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.String;
namespace Kata3
{
    public class Program
    {
        //Write a function that takes in a string of one or more words,
        //and returns the same string,
        //but with all words that have five or more letters reversed.

        //Strings passed in will consist of only letters and spaces.
        //Spaces will be included only when more than one word is present.

        static void Main(string[] args)
        {
        }
        public static string SpinWords(string sentence)
        {
            // Split the input sentence into words
            string[] words = sentence.Split(' ');

            // Process each word and reverse it if it has 5 or more letters
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length >= 5)
                {
                    // Convert the word to a char array to reverse it
                    char[] charArray = words[i].ToCharArray();
                    Array.Reverse(charArray);
                    words[i] = new string(charArray);
                }
            }
            string result = string.Join(" ", words);

            return result;
        }
    }
}
