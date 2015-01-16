using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5_Change_Even_Bits
{
    class Program
    {
        static void Main(string[] args)
        {
        }


        static int GetBitPoss(int number, int position)
        {
            int nRightPoss = number >> position;
            int bit = nRightPoss & 1;
            return bit;
        }

        static int SetBitToZero(int number, int position)
        {
            int mask = 1 << position;
            int result = number & mask;
            return result;
        }



    }
}
