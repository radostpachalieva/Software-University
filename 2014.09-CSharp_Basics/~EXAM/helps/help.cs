using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helps
{
    class help
    {
        
        //Console.WriteLine("No"); // +10 тоооочкииии :D


        static void Main(string[] args)
        {



            //========================================================

            // Now count the bits. There are many ways to do this...
            // Here we're using Brian Kernighan's hack
            ulong bits = ulong.Parse(Console.ReadLine());
            int bitCount = 0;
            while (bits != 0)
            {
                bits &= (bits - 1);
                bitCount += 1;
            }
            Console.WriteLine(bitCount);

            //=========================================================

            int n = int.Parse(Console.ReadLine());
            int result = CalcSumOfDigits(n);

            Console.WriteLine(result);
        
        }

        // ======================================================================

        static int SumChars(string str)
        {
            int sum = 0;
            foreach (char ch in str)
            {
                sum += (int)ch;
            }
            return sum;
        }

        // ======================================================================

       
        private static string CalcIntToBinary(int n)
        {

            //int n = int.Parse(Console.ReadLine());

            int num = int.Parse(Console.ReadLine());
            string binary = Convert.ToString(num, 2).PadLeft(8, '0');
            //Console.WriteLine(binary);
            return binary;

        }
        
        // ======================================================================
        private static int CalcSumOfDigits(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num = num / 10;
            }
            return sum;
        }

        // ======================================================================
        private static bool IsAllowedNumber(int num)
        {
            string digits = num.ToString();
            foreach (var digit in digits)
            {
                if (digit < '1' || digit > '7')
                {
                    return false;
                }
            }
            return true;
        }

        // ======================================================================
        //private static bool IsAllowedNumber(int num)
        //{
        //    string digits = num.ToString();
        //    foreach (var digit in digits)
        //    {
        //        if (digit < '5' || digit > '9')
        //        {
        //            return false;
        //        }
        //    }
        //    return true;

        //}

        // ======================================================================





    }
}
