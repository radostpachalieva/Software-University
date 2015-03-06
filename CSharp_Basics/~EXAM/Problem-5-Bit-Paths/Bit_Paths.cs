using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5_Bit_Paths
{
    class Bit_Paths
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int[] board = new int[8];

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                //int path = input.Split(',').Select(int.Parse).ToArray();
                //int path2 = Array.ConvertAll(input.Split(',')), element => int.Parse(element);
                string[] currentPath = input.Split(',');    // Split - прави стрингове в масиви по определен знак ','
                int[] path = new int[8];

                for (int j = 0; j < 8; j++)
                {
                    path[j] = int.Parse(currentPath[j]);

                }

                int startPosition = 3 - path[0];

                for (int k = 0; k < 7; k++)
                {
                    //Console.WriteLine(Convert.ToString(board[k], 2).PadLeft(4, '0'));
                    int mask = (1 << startPosition);
                    board[k] = board[k] ^ mask;     // da mask! - ^ променя 1-ата, но не променя нулата. Когато имаме 1 на едни и същи места (boards се пресичат ==> става нула!.
                    //Console.WriteLine(Convert.ToString(board[k], 2).PadLeft(4, '0'));

                    startPosition -= path[k+1];
                }
            }
            int sum = board.Sum();

            Console.WriteLine(Convert.ToString(sum, 2));
            Console.WriteLine(sum.ToString("X"));


        }
    }
}
