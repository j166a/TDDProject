using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDProject
{
    public class WordAnalyser
    {
        public static List<string> FindLongestWords(string text)
        {
            string currentLongestWord = "";
            int currentLongestWordLength = 0;
            List<string> listOfLongestWords = new List<string>();

            string[] textArray = text.Split(' ');
            foreach (string word in textArray)
            {
                if (word.Length > currentLongestWordLength)
                {
                    listOfLongestWords.Clear();
                    listOfLongestWords.Add(word);
                    currentLongestWordLength = word.Length;
                }
                else if (word.Length == currentLongestWordLength)
                {
                    listOfLongestWords.Add(word);
                }
            }

            return listOfLongestWords;
        }

        public Dictionary<char, int> CalculateLetterFrequency(string text)
        {
            // TODO: Implement the logic to calculate the frequency of each letter in the given text
            return new Dictionary<char, int>();
        }
    }
}
