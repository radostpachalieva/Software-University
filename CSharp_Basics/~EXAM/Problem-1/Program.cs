using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int nAmountMoney = int.Parse(Console.ReadLine());
            int pWeekDaysOut = int.Parse(Console.ReadLine());
            int hWeekDaysHome = int.Parse(Console.ReadLine());

            int normalDays = 22;
            int weekEndDays = 8;
            int rent = 150;

            int normalWeekEnd = (weekEndDays - 2*hWeekDaysHome)*20; // 

            int countNormalDays = (normalDays - pWeekDaysOut)*10;

            int countOut = pWeekDaysOut * ((nAmountMoney * 3 / 100) + 10);

            int total = normalWeekEnd + countNormalDays + countOut + rent;

            //Console.WriteLine(total);

            int totalLeft = nAmountMoney - total;

            //Console.WriteLine(totalLeft);


            if (totalLeft == 0)
            {
                Console.WriteLine("Exact Budget.");
            }

            if (totalLeft > 0)
            {
                Console.WriteLine("Yes, leftover {0}.", totalLeft);
            }

            if (totalLeft < 0)
            {
                Console.WriteLine("No, not enough {0}.", Math.Abs(totalLeft));
            }

        }
    }
}
