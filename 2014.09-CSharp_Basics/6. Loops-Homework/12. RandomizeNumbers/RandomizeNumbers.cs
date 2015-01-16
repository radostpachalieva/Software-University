using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.RandomizeNumbers
{
    class RandomizeNumbers
    {

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            UniqueRandomArray(array, n);

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }

        private static int[] UniqueRandomArray(int[] uniqueArray, int size)
        {
            Random rnd = new Random();
            int randomNumber;

            for (int i = 0; i < size; i++)
            {
                randomNumber = rnd.Next(1, size);

                for (int j = i; j >= 0; j--)
                {
                    if (uniqueArray[j] == randomNumber)
                    {
                        randomNumber = rnd.Next(1, size + 1);
                        j = i;
                    }
                }

                uniqueArray[i] = randomNumber;
            }

            return uniqueArray;
        }


    }
}
