using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.JoinLists
{
    class JoinLists
    {
        static void Main(string[] args)
        {

            //Test 1:
            Console.SetIn(new StreamReader("../../input.txt"));
            //Test 2:
            //Console.SetIn(new StreamReader("../../input2.txt"));
            //Test 3:
            //Console.SetIn(new StreamReader("../../input3.txt"));

            //After long hours of solving this problem, I decided to use SortedSet class
            //It sorts automatically unique elements in increasing order.

            string[] firstLine = Console.ReadLine().Split(' ');
            string[] secondLine = Console.ReadLine().Split(' ');

            SortedSet<int> sortedNumbers = new SortedSet<int>();
            foreach (var number in firstLine) sortedNumbers.Add(int.Parse(number));
            foreach (var number in secondLine) sortedNumbers.Add(int.Parse(number));
            foreach (var number in sortedNumbers) Console.Write(number + " ");

        }
    }
}
