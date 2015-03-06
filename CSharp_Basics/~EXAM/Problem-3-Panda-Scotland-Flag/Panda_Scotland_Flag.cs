using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3_Panda_Scotland_Flag
{
    class Panda_Scotland_Flag
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int diesInside = n - 2;
            int tildOutside = 0;
            char letter = 'A';


            for (int i = 0; i < n / 2; i++)
            {
                Console.Write(new string('~', tildOutside));
                Console.Write(letter);
                letter = ChangeLetter(letter);
                Console.Write(new string('#', diesInside));
                Console.Write(letter);
                letter = ChangeLetter(letter);
                Console.Write(new string('~', tildOutside));
                Console.WriteLine();
                tildOutside++;
                diesInside -= 2;
            }
            
            Console.WriteLine("{0}{1}{0}", new string('-', n / 2), letter);
            letter = ChangeLetter(letter);

            diesInside = 1;
            tildOutside = (n / 2) - 1;

            for (int i = 0; i < n / 2; i++)
            {
                Console.Write(new string('~', tildOutside));
                Console.Write(letter);
                letter = ChangeLetter(letter);
                Console.Write(new string('#', diesInside));
                Console.Write(letter);
                letter = ChangeLetter(letter);
                Console.Write(new string('~', tildOutside));
                Console.WriteLine();
                tildOutside--;
                diesInside += 2;
            }

        }

        static char ChangeLetter(char letter)
        {
            letter++;

            if (letter > 'Z')
            {
                letter = 'A';
            }
            return letter;
        }

    }
}
