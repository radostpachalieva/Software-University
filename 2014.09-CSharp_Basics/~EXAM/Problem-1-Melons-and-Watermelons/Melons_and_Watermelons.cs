using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1_Melons_and_Watermelons
{
    class Melons_and_Watermelons
    {
        static void Main(string[] args)
        {

            int startDay = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            int countMelons = 0;
            int countWaterMelons = 0;

            for (int i = startDay; i < startDay + days; i++)
            {

                int daysOfWeek = (i % 7);

                switch (daysOfWeek)
                {
                    case 1: countWaterMelons++; break;
                    case 2: countMelons+=2; break;
                    case 3: countWaterMelons++; countMelons++ ; break;
                    case 4: countWaterMelons += 2; break;
                    case 5: countWaterMelons += 2; countMelons += 2; break;
                    case 6: countWaterMelons++; countMelons += 2; break;
                }
            }

            int diff = Math.Abs(countMelons - countWaterMelons);

            if (countWaterMelons==countMelons)
            {
                Console.WriteLine("Equal amount: {0}", countMelons);
            }

            else if (countWaterMelons > countMelons)
            {
                Console.WriteLine("{0} more watermelons", diff);
            }
            else if (countWaterMelons < countMelons)
            {
                Console.WriteLine("{0} more melons", diff);
            }



        }
    }
}
