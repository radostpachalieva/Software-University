using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3_Forest_Road
{
    class ForestRoad
    {

        //static Boolean DotOrStar(int i, int j)
        //{
        //    if (i == j) Console.Write('*');
        //    else Console.Write('.'); 
        //}


        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    DotOrStar(); 
                }
                Console.WriteLine(); 
            }


            for (int i = n - 1; i >= 1; i--)
            {
                for (int j = 1; j <= n; j++)
                {
                    DotOrStar();
                }
                Console.WriteLine();
            }
        }




        private static void DotOrStar()
        {
            throw new NotImplementedException();
        }

private static void DotOrStar(int i, int j)
{
    if (i == j) Console.Write('^');
    else Console.Write('.');  
}
    }
}
