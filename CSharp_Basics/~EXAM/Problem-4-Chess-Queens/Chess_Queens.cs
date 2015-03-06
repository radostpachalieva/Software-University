using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4_Chess_Queens
{
    class Chess_Queens
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int diff = d + 1;                   // защото не става въпрос за d стойности, а да прескочи d стойности => +1
            char[] letters = new char[n];       // a b c d e f .....
            bool noValid = true;

            for (int i = 0; i < n; i++)         // a b c d e f .....
            {
                letters[i] = (char)('a' + i);
            }

            for (int x1 = 0; x1 < n; x1++)
            {
                for (int y1 = 0; y1 < n; y1++)
                {
                    for (int x2 = 0; x2 < n; x2++)
                    {
                        for (int y2 = 0; y2 < n; y2++)
                        {
                            bool xMeet = x1 == x2 && Math.Abs(y1 - y2) == diff;     // за (a,b,c..) вертикала - абсолютната стойност на разликата между двете положения да е равна на скока, който се въвежда!
                            bool yMeet = y1 == y2 && Math.Abs(x1 - x2) == diff;     // за (1,2,3..) хоризонтала
                            bool diagonalMeet = Math.Abs(x1 - x2) == diff && Math.Abs(y1 - y2) == diff; // за диагонал!

                            if (xMeet || yMeet || diagonalMeet)         // ако едно от трите е изпълнено:
                            {
                                Console.WriteLine("{0}{1} - {2}{3}", letters[x1], y1 + 1, letters[x2], y2 + 1); //y*+1 защото y започва от 0
                                noValid = false;
                            }
                        }
                    }
                }
            }
            if (noValid)        // проверката е валидна, тоест няма решение на горните
            {
                Console.WriteLine("No valid positions");
            }

        }
    }
}
