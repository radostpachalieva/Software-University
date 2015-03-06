using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.LongestWord
{
    class LongestWord
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().TrimEnd('.');
            string[] words = input.Split(' ');

            int letterCounter = 0;
            int maxCount = 0;
            string longestWord = "";

            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < words[i].Length; j++)
                {
                    letterCounter++;

                    if (letterCounter >= maxCount)
                    {
                        maxCount = letterCounter;
                        longestWord = words[i];
                    }
                }
                letterCounter = 0;
            }
            Console.WriteLine(longestWord);

        }
    }
}
