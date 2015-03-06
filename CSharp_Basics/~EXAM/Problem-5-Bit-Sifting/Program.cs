using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5_Bit_Sifting
{
    class Program
    {
        static void Main(string[] args)
        {
                    
            ulong bits = ulong.Parse(Console.ReadLine());
            int sieves = int.Parse(Console.ReadLine());

            for (int i = 0; i < sieves; ++i)
            {
                ulong sieve = ulong.Parse(Console.ReadLine());
                bits = (bits ^ sieve) & bits;
            }
            // Now count the bits. There are many ways to do this...
            // Here we're using Brian Kernighan's hack
            int bitCount = 0;
            while (bits != 0)
            {
                bits &= (bits - 1);
                bitCount += 1;
            }
            Console.WriteLine(bitCount);
            
        }
    }
}
