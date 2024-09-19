using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Highest_Scoring_Word
{
    internal class Program
    {

        public static int HighestScore(string word)
        {
            char[] alphabet = new char[] {
                'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm',
                'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'
            };
            int totalScore = 0;

            foreach (char letter in word)
            {
                char lowercase = char.ToLower(letter);

                int position = Array.IndexOf(alphabet, lowercase) + 1;

                totalScore += position;
            }

            return totalScore;
        }
        static void Main(string[] args)
        {
            string word1 = "Alonso";
            string word2 = "Aaron";

            int scoreWord1 = HighestScore(word1);
            int scoreWord2 = HighestScore(word2);

            if (scoreWord1 > scoreWord2)
            {
                Console.WriteLine(word1);
            }
            else if (scoreWord2 > scoreWord1)
            {
                Console.WriteLine(word2);
            }
            else
            {
                Console.WriteLine(word1); 
            }
            Console.ReadKey();
        }
    }
}
