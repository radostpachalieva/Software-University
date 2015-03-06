using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace Problem_1_ShipDamage
//{
//    class ShipDamage
//    {
//        static void Main(string[] args)
//        {
//            int sx1 = int.Parse(Console.ReadLine());
//            int sy1 = int.Parse(Console.ReadLine());
//            int sx2 = int.Parse(Console.ReadLine());
//            int sy2 = int.Parse(Console.ReadLine());
//            int h = int.Parse(Console.ReadLine());

//            int minX = Math.Min(sx1, sx2);
//            int maxX = Math.Max(sx1, sx2);
//            int minY = Math.Min(sy1, sy2);
//            int maxY = Math.Max(sy1, sy2);

//            int damage = 0;

//            for (int i = 0; i <= 3; i++)
//            {
//                int x = int.Parse(Console.ReadLine());
//                int y = int.Parse(Console.ReadLine());

//                y = 2 * h - y;

//                damage += CalcDamage(x, y, minX, maxX, minY, maxY);
//                //if (((x == minX) || (x == maxX)) &&
//                //((y == minY) || (y == maxY)))
//                //{
//                //    damage+= 25;       // Corner
//                //}

//                //if (((x > minX) && (x < maxX)) &&
//                //     ((y == minY) || (y == maxY)))
//                //{
//                //    damage += 50;       // Line Y
//                //}

//                //if (((y > minY) && (y < maxY)) &&
//                //    ((x == minX) || (x == maxX)))
//                //{
//                //    damage += 50;       // Line X
//                //}

//                //if (((x > minX) && (x < maxX)) &&
//                //     ((y > minY) || (y < maxY)))
//                //{
//                //    damage += 100;       // Inside
//                //}


//            }

//            Console.WriteLine(damage + "%");
//        }

//        private static int CalcDamage(int x, int y, int minX, int maxX, int minY, int maxY)
//        {
//            if (((x == minX) || (x == maxX)) &&
//                ((y == minY) || (y == maxY)))
//            {
//                return 25;       // Corner
//            }

//            if (((x > minX) && (x < maxX)) &&
//                 ((y == minY) || (y == maxY)))
//            {
//                return 50;       // Line Y
//            }

//            if (((y > minY) && (y < maxY)) &&
//                ((x == minX) || (x == maxX)))
//            {
//                return 50;       // Line X
//            }

//            if (((x > minX) && (x < maxX)) &&
//                 ((y > minY) || (y < maxY)))
//            {
//                return 100;       // Inside
//            }

//            return 0;
//        }

//    }
//}
//--------------------------------------------------------------------

namespace Problem_1_ShipDamage
{
    class Program
    {
        static void Main(string[] args)
        {
            int sx1 = int.Parse(Console.ReadLine());
            int sy1 = int.Parse(Console.ReadLine());
            int sx2 = int.Parse(Console.ReadLine());
            int sy2 = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            int cx1 = int.Parse(Console.ReadLine());
            int cy1 = int.Parse(Console.ReadLine());
            int cx2 = int.Parse(Console.ReadLine());
            int cy2 = int.Parse(Console.ReadLine());
            int cx3 = int.Parse(Console.ReadLine());
            int cy3 = int.Parse(Console.ReadLine());

            cy1 = 2 * h - cy1;
            cy2 = 2 * h - cy2;
            cy3 = 2 * h - cy3;

            int minX = Math.Min(sx1, sx2);
            int maxX = Math.Max(sx1, sx2);
            int minY = Math.Min(sy1, sy2);
            int maxY = Math.Max(sy1, sy2);

            int damage = 0;
            damage += CalcDamage(cx1, cy1, minX, maxX, minY, maxY);
            damage += CalcDamage(cx2, cy2, minX, maxX, minY, maxY);
            damage += CalcDamage(cx3, cy3, minX, maxX, minY, maxY);

            Console.WriteLine(damage + "%");
        }

        private static int CalcDamage(int x, int y, int minX, int maxX, int minY, int maxY)
        {
            if (((x == minX) || (x == maxX)) &&
                ((y == minY) || (y == maxY)))
            {
                return 25;       // Corner
            }

            if (((x > minX) && (x < maxX)) &&
                 ((y == minY) || (y == maxY)))
            {
                return 50;       // Line Y
            }

            if (((y > minY) && (y < maxY)) &&
                ((x == minX) || (x == maxX)))
            {
                return 50;       // Line X
            }

            if (((x > minX) && (x < maxX)) &&
                 ((y > minY) || (y < maxY)))
            {
                return 100;       // Inside
            }

            return 0;
        }

    }
}