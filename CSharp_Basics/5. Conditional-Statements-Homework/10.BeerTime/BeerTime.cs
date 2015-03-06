using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 10.	* Beer Time
//A beer time is after 1:00 PM and before 3:00 AM. Write a program that enters a time in format “hh:mm tt” 
//(an hour in range [01...12], a minute in range [00…59] and AM / PM designator) and prints “beer time” or 
//“non-beer time” according to the definition above or “invalid time” if the time cannot be parsed. 
//Note that you may need to learn how to parse dates and times. 
//Examples:
//time	result
//1:00 PM	beer time
//4:30 PM	beer time
//10:57 PM	beer time
//8:30 AM	non-beer time
//02:59 AM	beer time
//03:00 AM	non-beer time
//03:26 AM	non-beer time


namespace _10.BeerTime
{
    class BeerTime
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a time in format \"hh:mm tt\" (Example: 04:32 PM) ");
            DateTime inputTime = DateTime.Parse(Console.ReadLine());
            int hour = inputTime.TimeOfDay.Hours;

            if ((hour >= 13 && hour <= 24) || (hour >= 0 && hour <= 3))
            {
                Console.WriteLine("Cheers! It's a beer time!");
            }
            else Console.WriteLine("Sorry, non-beer time");

        }
    }
}
