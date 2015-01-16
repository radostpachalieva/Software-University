using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // 2 sets
            int c = int.Parse(Console.ReadLine());  // 5 numbers
            string s = Console.ReadLine(); // odd or even

            string[] numberSet = { "First", "Second", "Third", "Fourth", "Fifth", "Sixth", "Seventh",
                                 "Eighth", "Ninth", "Tenth"};

            int countSet = 0;
            int bestCountSet = 0;
            int maxOdd = int.MinValue;
            int maxEven = int.MinValue;

            if (s == "odd")
            {

                for (int i = 1; i <= n; i++)
                {
                    int countOdd = 0;
                    int countEven = 0;

                    for (int j = 0; j < c; j++)
                    {
                        int element = int.Parse(Console.ReadLine());
                        if (element % 2 == 0)
                            countEven++;
                        else
                            countOdd++;
                     }

                    
                    if (countOdd > maxOdd)
                    {
                        maxOdd = countOdd;
                        countSet++;
                        //bestCountSet = countSet;

                    }

                    else
                    {
                        maxOdd = countOdd;
                       
                    }
                    
                }
                
                if (maxOdd == 0)
                    Console.WriteLine("No");
                else
                    Console.WriteLine("{0} set has the most {1} numbers: {2}", numberSet[bestCountSet], s, maxOdd); 
            }

                //====================================================================================================
            else if (s == "even")
            {

                for (int i = 1; i <= n; i++)
                {
                    int countOdd = 0;
                    int countEven = 0;

                    for (int j = 0; j < c; j++)
                    {
                        int element = int.Parse(Console.ReadLine());
                        if (element % 2 == 0)
                            countEven++;
                        else
                            countOdd++;
                    }

                    if (countEven > maxEven)
                    {
                        maxEven = countEven;
                        countSet++;
                        bestCountSet = countSet;
                    }

                    else
                    {
                        maxEven = countEven;
                        
                    }

                }

                if (maxEven == 0)
                    Console.WriteLine("No");
                else
                    Console.WriteLine("{0} set has the most {1} numbers: {2}", numberSet[bestCountSet], s, maxEven);
            }

            if (n == 0 || c == 0)
            {
                Console.WriteLine("No");
            }

        }
    }
}
