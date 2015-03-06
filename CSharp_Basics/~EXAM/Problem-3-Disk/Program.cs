using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3_Disk
{
    class Program
    {
        static void Main(string[] args)
        {

            int fieldSize = int.Parse(Console.ReadLine());
            int radius = int.Parse(Console.ReadLine());
            int diskCenterRow = fieldSize / 2,
                diskCenterCol = fieldSize / 2;

            for (int currentRow = 0; currentRow < fieldSize; currentRow++)
            {
                for (int currentCol = 0; currentCol < fieldSize; currentCol++)
                {
                    int deltaX = currentCol - diskCenterCol,
                        deltaY = currentRow - diskCenterRow;
                    double distanceToCenter = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
                    bool isWithinDisk = distanceToCenter <= radius;

                    if (isWithinDisk)
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write('.');
                    }
                }
                Console.WriteLine();
            }

        }
    }
}
