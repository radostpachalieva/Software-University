using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4_Magic_Strings
{
    class MagicStrings
    {

        static void Main()
        {
            int diff = int.Parse(Console.ReadLine());
            string[] letters = { "k", "n", "p", "s" };
            int[] weight = { 1, 4, 5, 3 };

            int counter = 0;
            int rightWeight = 0;
            int leftWeight = 0;
            for (int i1 = 0; i1 < 4; i1++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    for (int i3 = 0; i3 < 4; i3++)
                    {
                        for (int i4 = 0; i4 < 4; i4++)
                        {
                            for (int i5 = 0; i5 < 4; i5++)
                            {
                                for (int i6 = 0; i6 < 4; i6++)
                                {
                                    for (int i7 = 0; i7 < 4; i7++)
                                    {
                                        for (int i8 = 0; i8 < 4; i8++)
                                        {
                                            leftWeight = weight[i1] + weight[i2] + weight[i3] + weight[i4];
                                            rightWeight = weight[i5] + weight[i6] + weight[i7] + weight[i8];

                                            if (Math.Abs(leftWeight - rightWeight) == diff)
                                            {
                                                string sequence1 = letters[i1] + letters[i2] + letters[i3] + letters[i4] +
                                                    letters[i5] + letters[i6] + letters[i7] + letters[i8];
                                                Console.WriteLine(sequence1);
                                                counter++;
                                            }

                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (counter == 0)
            {
                Console.WriteLine("No");
            }
        }


        //--------------------------------------------------------------------------------------------
        //static void Main()
        //{
        //    int diff = int.Parse(Console.ReadLine());
        //    char[] letters = { 'k', 'n', 'p', 's' };

        //    int resultsCount = 0;
        //    for (int d1 = 0; d1 < letters.Length; d1++)
        //    {
        //        for (int d2 = 0; d2 < letters.Length; d2++)
        //        {
        //            for (int d3 = 0; d3 < letters.Length; d3++)
        //            {
        //                for (int d4 = 0; d4 < letters.Length; d4++)
        //                {
        //                    string left = "" + letters[d1] + letters[d2] + letters[d3] + letters[d4];
        //                    int weightLeft = CalcWeight(left);
        //                    for (int d5 = 0; d5 < letters.Length; d5++)
        //                    {
        //                        for (int d6 = 0; d6 < letters.Length; d6++)
        //                        {
        //                            for (int d7 = 0; d7 < letters.Length; d7++)
        //                            {
        //                                for (int d8 = 0; d8 < letters.Length; d8++)
        //                                {
        //                                    string right = "" + letters[d5] + letters[d6] + letters[d7] + letters[d8];
        //                                    int weightRight = CalcWeight(right);
        //                                    if (Math.Abs(weightLeft - weightRight) == diff)
        //                                    {
        //                                        Console.WriteLine(left + right);
        //                                        resultsCount++;
        //                                    }
        //                                }
        //                            }
        //                        }
        //                    }
        //                }
        //            }
        //        }
        //    }

        //    if (resultsCount == 0)
        //    {
        //        Console.WriteLine("No");
        //    }
        //}

        //private static int CalcWeight(string str)
        //{
        //    int weight = 0;
        //    foreach (var ch in str)
        //    {
        //        switch (ch)
        //        {
        //            case 's': weight += 3; break;
        //            case 'n': weight += 4; break;
        //            case 'k': weight += 1; break;
        //            case 'p': weight += 5; break;
        //        }
        //    }
        //    return weight;
        //}


    }
}
