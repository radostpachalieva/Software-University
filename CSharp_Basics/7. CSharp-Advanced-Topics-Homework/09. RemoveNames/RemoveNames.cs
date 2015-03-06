using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.RemoveNames
{
    class RemoveNames
    {
        static void Main(string[] args)
        {

            //Test 1:
            //Console.SetIn(new StreamReader("../../input.txt"));
            //Test 2:
            //Console.SetIn(new StreamReader("../../input2.txt"));

            string[] firstLine = Console.ReadLine().Split(' ');
            List<string> names = new List<string>();

            string[] secondLine = Console.ReadLine().Split(' ');

            for (int i = 0; i < firstLine.Length; i++)
            {
                names.Add(firstLine[i]); //fill the list

                for (int j = 0; j < secondLine.Length; j++)
                {
                    if (firstLine[i] == secondLine[j])
                    {
                        names.Remove(firstLine[i]); //remove repeats
                    }
                }
            }

            //Print the result
            foreach (var name in names)
            {
                Console.Write(name + " ");
            }
            Console.WriteLine();

        }
    }
}
