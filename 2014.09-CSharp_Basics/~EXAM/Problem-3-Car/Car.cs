using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3_Car
{
    class Car
    {
        static void Main(string[] args)
        {

            //int n = int.Parse(Console.ReadLine());
            //int dots = n;
            //int stars = n;
            //int dotsMiddle = stars;

            //Console.WriteLine("{0}{1}{0}", new string('.', dots), new string('*', stars));
            //for (int i = 0; i < n / 2 - 1; i++)
            //{
            //    dots--;
            //    Console.WriteLine("{0}*{1}*{0}", new string('.', dots), new string('.', dotsMiddle));
            //    dotsMiddle += 2;
            //}

            //Console.WriteLine("{0}{1}{0}", new string('*', dots), new string('.', n * 2 - 2));
            //for (int i = 0; i < n / 2 - 2; i++)
            //{
            //    Console.WriteLine("*{0}*", new string('.', n * 3 - 2));
            //}

            //int middleDots = (n / 2 + 1) + (n - 6) / 2;
            //Console.WriteLine(new string('*', n * 3));
            //for (int i = 0; i < n / 2 - 2; i++)
            //{
            //    Console.WriteLine("{0}*{1}*{2}*{1}*{0}",
            //    new string('.', n / 2), new string('.', n / 2 - 1), new string('.', middleDots));
            //}

            //Console.WriteLine("{0}{1}{2}{1}{0}",
            //new string('.', n / 2), new string('*', n / 2 + 1), new string('.', middleDots));








            int n = int.Parse(Console.ReadLine());


            int dotCountOut = n - 1;
            int dotCountIn = n;

            Console.WriteLine("{0}{1}{0}", new string('.', n), new string('*', n));

            for (int i = 0; i < n/2 - 1; i++)
            {
                Console.Write(new string('.', dotCountOut-i));
                Console.Write('*');
                Console.Write(new string('.', dotCountIn+2*i));
                Console.Write('*');
                Console.Write(new string('.', dotCountOut-i));
                Console.WriteLine();
            }

            Console.WriteLine("{0}{1}{0}", new string('*', n / 2 + 1), new string('.', n * 2 - 2));

            for (int i = 0; i < n / 2 - 2; i++)
            {
                Console.Write(new string('*', 1));

                Console.Write(new string('.', dotCountOut*3+1));

                Console.Write(new string('*', 1));
                Console.WriteLine();
            }
            Console.WriteLine(new string('*', n * 3));

            for (int i = 0; i <= n / 2 - 3; i++)
            {
                Console.Write(new string('.', n/2));
                Console.Write(new string('*', 1));
                Console.Write(new string('.', n / 2-1));
                Console.Write(new string('*', 1));
                Console.Write(new string('.', n-2));
                Console.Write(new string('*', 1));
                Console.Write(new string('.', n / 2 - 1));
                Console.Write(new string('*', 1));
                Console.Write(new string('.', n / 2));
                Console.WriteLine();
            }

                Console.Write(new string('.', n / 2));
                Console.Write(new string('*', n/2 +1));
                Console.Write(new string('.', n - 2));
                Console.Write(new string('*', n/2 +1));
                Console.Write(new string('.', n / 2));
                Console.WriteLine();

        }
    }
}




