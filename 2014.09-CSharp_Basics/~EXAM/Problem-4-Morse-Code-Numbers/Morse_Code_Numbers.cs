using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4_Morse_Code_Numbers
{
    class Morse_Code_Numbers
    {
        static void Main(string[] args)
        {

            // 1. Сумата на цифрите с %10 = nSum
            // 2. Масив от стрингове (0 = “-----”, 1 = “.----”, 2 = “..---”, 3 = “...--”, 4 = “....-”, 5 = “.....”)
            // 3. morseProduct
            // Вложени цикъла = 6, защото 6 броя са символите/вариантите


            int n = int.Parse(Console.ReadLine());

            int nSum = 0;
            while (n > 0)
            {
                nSum += n % 10;
                n /= 10;
            }

            string[] morseCodes = { "-----", ".----", "..---", "...--", "....-", "....." };
            bool foundAnswer = false;
            for (int i0 = 0; i0 <= 5; i0++)
            {
                for (int i1 = 0; i1 <= 5; i1++)
                {
                    for (int i2 = 0; i2 <= 5; i2++)
                    {
                        for (int i3 = 0; i3 <= 5; i3++)
                        {
                            for (int i4 = 0; i4 <= 5; i4++)
                            {
                                for (int i5 = 0; i5 <= 5; i5++)
                                {
                                    int morseProduct = i0 * i1 * i2 * i3 * i4 * i5;
                                    if (morseProduct == nSum)
                                    {
                                        string morseNumber =
                                            morseCodes[i0] + "|" +
                                            morseCodes[i1] + "|" +
                                            morseCodes[i2] + "|" +
                                            morseCodes[i3] + "|" +
                                            morseCodes[i4] + "|" +
                                            morseCodes[i5] + "|";
                                        foundAnswer = true;
                                        Console.WriteLine(morseNumber);
                                    }
                                }
                            }
                        }
                    }
                }
            }

            if (!foundAnswer)
            {
                Console.WriteLine("No");
            }



        }
    }
}
