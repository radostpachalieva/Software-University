using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.CountOfNames
{
    class CountOfNames
    {
        static void Main(string[] args)
        {

            //This solution is ABSOLUTELY the same, like for the "Count of letters" task.

            string[] input = Console.ReadLine().Split(' ');
            Array.Sort(input);

            var words = new HashSet<string>();
            for (int i = 0; i < input.Length; i++)
            {
                words.Add(input[i]);
            }

            int count = 0;
            foreach (string letter in words)
            {
                for (int j = 0; j < input.Length; j++)
                {
                    if (letter == input[j]) count++;
                }

                Console.WriteLine(letter + " -> " + count);
                count = 0;
            }
            Console.WriteLine();

        }
    }
}
