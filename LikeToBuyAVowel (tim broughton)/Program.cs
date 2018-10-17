using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeToBuyAVowel__tim_broughton_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Before we begin...\nWould you like to consider 'Y' a vowel?\n(type 'y' for yes, anything else for no!)");

            char isY = Console.ReadKey(true).KeyChar;

            if (isY == 'y' || isY == 'Y')
            {
                Console.WriteLine("Y will be treated as a vowel!");
            }
            else
            {
                Console.WriteLine("Y will be treated as a consonant!");
            }

            Console.WriteLine("\nPlease enter a line of text to count the vowels in it! :");

            string userInput = Console.ReadLine();
            char[] vowels = new char[6];

            if (isY == 'y' || isY == 'Y')
            {
                vowels = new char[] { 'a', 'e', 'i', 'o', 'u', 'y' };
            }
            else
            {
                vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
            }

            int counter = 0;

            foreach(char letter in userInput.ToLower())
            {
                if (vowels.Contains(letter))
                {
                    counter++;
                }
            }

            Console.WriteLine("There are {0} vowels in the string {1}",counter, userInput);

            Console.ReadKey();

        }
    }
}
