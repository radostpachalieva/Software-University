using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Problem_1_Exam_Schedule
{
    class Exam_Schedule
    {
        static void Main(string[] args)
        {
            //int startHour = int.Parse(Console.ReadLine());
            //int startMinutes = int.Parse(Console.ReadLine());
            //string partOfDay = Console.ReadLine();
            //int durationHours = int.Parse(Console.ReadLine());
            //int durationMinutes = int.Parse(Console.ReadLine());

            //startHour = startHour % 12; // 6 % 12 = 6 || 12 % 12 = 0 || 16 % 12 = 4 || 25 % 12 = 1
            //if (partOfDay == "PM")
            //{
            //    startHour += 12;
            //}
            //DateTime startTime = new DateTime(2014, 04, 09, startHour, startMinutes, 0);
            //DateTime endTime = startTime.AddHours(durationHours).AddMinutes(durationMinutes);
            //Console.WriteLine("{0:hh:mm:tt}", endTime);

            //==============================================================================

            int hour = int.Parse(Console.ReadLine());
            int mins = int.Parse(Console.ReadLine());
            string PartOfDay = Console.ReadLine();
            int hourDuration = int.Parse(Console.ReadLine());
            int minsDuration = int.Parse(Console.ReadLine());

            int countHour = hour + hourDuration;
            int countMins = mins + minsDuration;

            if (countMins >= 60)
            {
                countHour += 1;
                countMins -= 60;
            }



            if (countHour == 12 && PartOfDay == "PM")
            {
                PartOfDay = "AM";
                Console.WriteLine("{0:D2}:{1:D2}:{2}", countHour, countMins, PartOfDay);
            }

            else if (countHour == 12 && PartOfDay == "AM")
            {
                PartOfDay = "PM";
                Console.WriteLine("{0:D2}:{1:D2}:{2}", countHour, countMins, PartOfDay);

            }

                //-----------------------------------------------------------------

            else if (countHour > 12 && PartOfDay == "PM")
            {
                if (countHour > 24)
                {
                    countHour -= 24;
                    Console.WriteLine("{0:D2}:{1:D2}:{2}", countHour, countMins, PartOfDay);
                }
                else if (countHour > 36)
                {
                    countHour -= 36;
                    PartOfDay = "AM";
                    Console.WriteLine("{0:D2}:{1:D2}:{2}", countHour, countMins, PartOfDay);
                }

                else
                {
                    countHour -= 12;
                    PartOfDay = "AM";
                    Console.WriteLine("{0:D2}:{1:D2}:{2}", countHour, countMins, PartOfDay);

                }

            }

            else if (countHour > 12 && PartOfDay == "AM")
            {

                if (countHour > 24)
                {
                    countHour -= 24;
                    Console.WriteLine("{0:D2}:{1:D2}:{2}", countHour, countMins, PartOfDay);
                }

                else if (countHour > 36)
                {
                    countHour -= 36;
                    PartOfDay = "PM";
                    Console.WriteLine("{0:D2}:{1:D2}:{2}", countHour, countMins, PartOfDay);
                }

                else
                {
                    countHour -= 12;
                    PartOfDay = "PM";
                    Console.WriteLine("{0:D2}:{1:D2}:{2}", countHour, countMins, PartOfDay);

                }
            }
            else
            {
                Console.WriteLine("{0:D2}:{1:D2}:{2}", countHour, countMins, PartOfDay);
            }
                
        }
    }
}
