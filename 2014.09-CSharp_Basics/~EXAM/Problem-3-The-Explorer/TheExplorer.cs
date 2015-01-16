using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3_The_Explorer
{
    class TheExplorer
    {

        static void Main()
        {            
            int width = int.Parse(Console.ReadLine());
            int height = width;
            string star = "*";
            string dash = "-";
            int lowerNumber = width / 2;
            int upperNumber = width / 2;

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (i == 0 && j == width / 2)
                    {
                        Console.Write(star);
                    }
                    else if (i > 0 && j == lowerNumber)
                    {
                        Console.Write(star);
                    }
                    else if (i > 0 && j == upperNumber)
                    {
                        Console.Write(star);
                    }
                    else
                    {
                        Console.Write(dash);
                    }
                }

                if (i < width / 2)
                {
                    lowerNumber--;
                    upperNumber++;
                }
                else
                {
                    lowerNumber++;
                    upperNumber--;
                }

                Console.WriteLine();
            }

            //-----------------------------------------------------------------
            //-----------------------------------------------------------------



            //int n = int.Parse(Console.ReadLine());
            //string topBottom = new string('-', n / 2) + "*" + new string('-', n / 2);
            //Console.WriteLine(topBottom);

            //int outDashes = n / 2 - 1;
            //int MidDashes = 1;
            //string star = "*";
            //char dashes = '-';

            //for (int i = 0; i < n / 2; i++)
            //{
            //    Console.WriteLine(new string(dashes, outDashes) + star + new string(dashes, MidDashes) 
            //        + star + new string(dashes, outDashes));

            //    outDashes--;
            //    MidDashes += 2;
            //}


            //outDashes = 1;
            //for (int i = 0; i < n / 2 - 1; i++)
            //{
            //    Console.WriteLine(new string(dashes, outDashes) + star + new string(dashes, n - outDashes * 2 - 2) 
            //        + star + new string(dashes, outDashes));

            //    outDashes += 1;
            //    MidDashes -= 2;
            //}
            //Console.WriteLine(topBottom);


        }
    }
}
