using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3_House
{
    class House
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("{1}{0}{1}", "*", new string('.', n / 2));

            for (int i = 1; i <= n - 3; i += 2)
            {
                int dashesCount = (n - i - 1) / 2;
                string dashes = new string('.', dashesCount);
                string asterisks = new string('*', i);
                Console.Write(dashes);
                Console.Write('*');
                Console.Write("{0}", new string('.', i));
                Console.Write('*');
                Console.Write(dashes);
                Console.WriteLine();
            }
            Console.WriteLine("{0}", new string('*', n));


            int wallDistance = n / 4;

            for (int i = n / 2 + 1; i < n - 1; i++)
            {
                Console.Write(new string('.', wallDistance));
                Console.Write(new string('*', 1));
                Console.Write(new string('.', n - 2 * wallDistance - 2));
                Console.Write(new string('*', 1));
                Console.WriteLine(new string('.', wallDistance));
            }

            Console.Write(new string('.', wallDistance));
            Console.Write(new string('*', n - 2 * wallDistance));
            Console.WriteLine(new string('.', wallDistance));


        }
    }
}
