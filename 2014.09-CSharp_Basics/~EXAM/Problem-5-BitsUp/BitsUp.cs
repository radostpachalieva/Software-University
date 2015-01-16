using System;

namespace Problem_5_BitsUp
{
    class BitsUp
    {
        static void Main(string[] args)
        {
            //int n = int.Parse(Console.ReadLine());
            //int step = int.Parse(Console.ReadLine());
            //string wholeNumber = "";
            //char[] Numbers = new char[n * 8];
            //string current = "";
            //for (int i = 0; i < n; i++)
            //{
            //    int number = int.Parse(Console.ReadLine());
            //    string binary = Convert.ToString(number, 2).PadLeft(8, '0');
            //    // Console.WriteLine(binary);
            //    wholeNumber += binary;
            //    // Console.WriteLine(wholeNumber);
            //    // wholeNumber.ToArray();
            //    Numbers = wholeNumber.ToCharArray();
            //}

            //for (int i = 0; i < n * 8; i++)
            //{
            //    if (step * i + 1 >= n * 8)
            //    {
            //        break;
            //    }
            //    if (Numbers[step * i + 1] == '0')
            //    {
            //        Numbers[step * i + 1] = '1';
            //    }

            //}

            //for (int i = 1; i <= Numbers.Length; i++)
            //{
            //    current += Convert.ToString(Numbers[i - 1]);
            //    if (i % 8 == 0)
            //    {
            //        Console.WriteLine(Convert.ToInt32(current, 2));
            //        current = "";
            //    }
            //}


            //------------------------------------------------------------------------------------

            int n = int.Parse(Console.ReadLine());
            int step = int.Parse(Console.ReadLine());
            int index = 0;

            //You are given a sequence of bytes. Consider each byte as sequences of exactly 8 bits. 
            //You are given also a number step. Write a program to set to 1 the bits at positions: 
            //1, 1 + step, 1 + 2*step, ... 
            //Print the output as a sequence of bytes.
            //Bits in each byte are counted from the leftmost to the rightmost. Bits are numbered starting from 0.

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                for (int bit = 7; bit >= 0; bit--)
                {
                    if ((index % step == 1) || (step == 1 && index > 0))
                    {
                        num = num | (1 << bit);
                    }
                    index++;
                }
                Console.WriteLine(num);
            }  
          

        }
    }
}
