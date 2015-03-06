using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Подготовка за изпит - C# част I (Niki™)

namespace Problem_3_Forest_Road
{
    class ForestRoad
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (i == j) Console.Write('*');
                    else Console.Write('.');                    
                }
                Console.WriteLine(); 
            }

            for (int i = n - 1; i >= 1; i--)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (i == j) Console.Write('*');
                    else Console.Write('.');
                }
                Console.WriteLine();
            }
        }
    }
}
