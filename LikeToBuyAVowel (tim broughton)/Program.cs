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
            Console.WriteLine("Please enter a line of text to count the vowels in it! :");

            string userInput = Console.ReadLine();

            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };

            int counter = 0;

            foreach(char letter in userInput)
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
