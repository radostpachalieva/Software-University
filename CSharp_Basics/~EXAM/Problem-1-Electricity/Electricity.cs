using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1_Electricity
{
    class Electricity
    {
        static void Main(string[] args)
        {
            int floors = int.Parse(Console.ReadLine());
            int flats = int.Parse(Console.ReadLine());
            DateTime time = DateTime.Parse(Console.ReadLine());

            DateTime firstStart = DateTime.Parse("14:00");
            DateTime firstEnd = DateTime.Parse("18:59");
            DateTime secondStart = DateTime.Parse("19:00");
            DateTime secondEnd = DateTime.Parse("23:59 ");
            DateTime thurdStart = DateTime.Parse("00:00");
            DateTime thurdEnd = DateTime.Parse("08:59");




            //•	From 14:00 to 18:59  2 lamps + 2 computers are running
            //•	From 19:00 to 23:59  7 lamps + 6 computers are running
            //•	From 00:00 to 08:59  1 lamp + 8 computers are running






        }
    }
}
