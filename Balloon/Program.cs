using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Balloon
{
    public class Program
    {
        static void Main(string[] args)
        {
            
        }

        public int number_Of_Times_Jumbled_Word_Occurs_In_Expected_Word(string expected_Word, string jumbled_Word)
        {
            Dictionary<string, int> expectedWord = GetLetterCount(expected_Word);
            Dictionary<string, int> jumbledWord = GetLetterCount(jumbled_Word);
            KeyValuePair<string, int> firstExpWord = jumbledWord.FirstOrDefault();
            int minCountPre = 0;
            if (expectedWord.Count() <= jumbledWord.Count())
            {
                minCountPre = firstExpWord.Value;
            }
            
            Console.WriteLine(firstExpWord.Key + " " + minCountPre);

            int minCount = 0;
            foreach (var item in expectedWord)
            {
                if (jumbledWord.ContainsKey(item.Key))
                {
                    jumbledWord.TryGetValue(item.Key, out int jCount);
                    expectedWord.TryGetValue(item.Key, out int expCount);
                    minCount = jCount / expCount;
                    if (minCount < minCountPre)
                    {
                        minCountPre = minCount;
                    }
                }
            }
            return minCountPre;
        }

        public static Dictionary<string, int> GetLetterCount(string input)
        {
            Dictionary<string, int> uniqueLetters = new Dictionary<string, int>();

            char[] inputConverted = input.ToCharArray();

            foreach (var item in inputConverted)
            {
                if (uniqueLetters.ContainsKey(item.ToString()))
                {
                    uniqueLetters.TryGetValue(item.ToString(), out int value);
                    uniqueLetters.Remove(item.ToString());
                    uniqueLetters.Add(item.ToString(), value + 1);
                }
                else
                {
                    uniqueLetters.Add(item.ToString(), 1);
                }
            }

            return uniqueLetters;
        }
    }
}
