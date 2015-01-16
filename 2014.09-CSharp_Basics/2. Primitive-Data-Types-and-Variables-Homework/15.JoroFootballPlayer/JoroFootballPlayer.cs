using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.JoroFootballPlayer
{
    class JoroFootballPlayer
    {
        static void Main(string[] args)
        {
            string kindOfYear = Console.ReadLine();
            int p = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            if (kindOfYear == "t")
            {
                Console.WriteLine("{0}", h + ((52 - h) * 2 * 1 / 3) + (p * 1 / 2) + 3); // броя на home + (52 - броя на home)*двата дни*дните когато е уморен + празници*1/2 + leap yr
            }
            else if (kindOfYear == "f")
            {
                Console.WriteLine("{0}", h + ((52 - h) * 2 * 1 / 3) + (p * 1 / 2));
            }
        }
    }
}
