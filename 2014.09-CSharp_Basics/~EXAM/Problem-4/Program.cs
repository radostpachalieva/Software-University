using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4
{
    class Program
    {

        static void Main(string[] args)
        {


            int diff = int.Parse(Console.ReadLine());

            string value = Console.ReadLine();

            char[] array = value.ToCharArray();

            for (int i = 0; i < array.Length; i++)
            {
                // Get character from array.
                char letter = array[i];
                // Display each letter.
                Console.Write("Letter: ");
                Console.WriteLine(letter);
            }




            int counter = 0;
            int rightWeight = 0;
            int leftWeight = 0;


            for (int i1 = i; i1 < 4; i1++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    for (int i3 = 0; i3 < 4; i3++)
                    {
                        for (int i4 = 0; i4 < 4; i4++)
                        {
                            for (int i5 = 0; i5 < 4; i5++)
                            {

                                leftWeight = weight[i1] + weight[i2] + weight[i3] + weight[i4];
                                rightWeight = weight[i5] + weight[i6] + weight[i7] + weight[i8];

                                if (Math.Abs(leftWeight - rightWeight) == diff)
                                {
                                    string sequence1 = input[i1] + input[i2] + input[i3] + input[i4] +
                                        input[i5] + input[i6] + input[i7] + input[i8];
                                    Console.WriteLine(sequence1);
                                    counter++;
                                }


                            }
                        }
                    }
                }
            }
            if (counter == 0)
            {
                Console.WriteLine("No");
            }





            Console.WriteLine("No");

        }


    }
}
