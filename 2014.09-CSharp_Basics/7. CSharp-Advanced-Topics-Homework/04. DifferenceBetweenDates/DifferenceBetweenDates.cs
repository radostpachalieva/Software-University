using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.DifferenceBetweenDates
{
    class DifferenceBetweenDates
    {
        static void Main()
        {
            DateTime startDate = DateTime.Parse(Console.ReadLine());
            DateTime endDay = DateTime.Parse(Console.ReadLine());
            double days = CountDays(startDate, endDay);

            Console.WriteLine("Days between: {0}", days);
        }

        private static double CountDays(DateTime start, DateTime end)
        {
            TimeSpan span = end - start;
            double result = span.TotalDays;

            return result;
        }

    }
}
