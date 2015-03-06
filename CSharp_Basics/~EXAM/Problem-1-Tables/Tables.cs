using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1_Tables
{
    class Tables
    {
        static void Main(string[] args)
        {

            long bundel1 = long.Parse(Console.ReadLine());
            long bundel2 = long.Parse(Console.ReadLine());
            long bundel3 = long.Parse(Console.ReadLine());
            long bundel4 = long.Parse(Console.ReadLine());

            long tableTops = long.Parse(Console.ReadLine());
            long tablesToBeMade = long.Parse(Console.ReadLine());

            long allLegs = bundel1 * 1 + bundel2 * 2 + bundel3 * 3 + bundel4 * 4;
            long tablePossible = Math.Min(tableTops, allLegs / 4);

            if (tablePossible==tablesToBeMade)
            {
                Console.WriteLine("Just enough tables made: {0}", tablesToBeMade);
            }

            else if (tablePossible>tablesToBeMade)
            {
                Console.WriteLine("more: {0}", tablePossible-tablesToBeMade);
                Console.WriteLine("tops left: {0}, legs left: {1}", 
                    Math.Max(0, tableTops - tablesToBeMade), allLegs-tablesToBeMade*4);
            }

            else
            {
                Console.WriteLine("less: {0}", tablePossible - tablesToBeMade);
                Console.WriteLine("tops needed: {0}, legs needed: {1}", 
                    Math.Max(0, tablesToBeMade - tableTops), Math.Max(0, tablesToBeMade*4 - allLegs));
            }

        }
    }
}
