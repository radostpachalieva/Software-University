using System;

namespace Problem_1_Work_Hours
{
    class WorkHours
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());

            decimal workDays = d * 0.9m;

            int workHoursPerDay = 12;
            decimal workingHours = Math.Floor(workDays * workHoursPerDay * p / 100.0m);

            if (h <= workingHours)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            Console.WriteLine(workingHours - h);
                        
            //int h = int.Parse(Console.ReadLine());
            //int d = int.Parse(Console.ReadLine());
            //int p = int.Parse(Console.ReadLine());

            //decimal workDays = d * 0.90m;
            //int workHoursPerDay = 12;
            //decimal workHours = Math.Floor(workDays * workHoursPerDay * p / 100.0m);

            //if (h <= workHours) 
            //{
            //    Console.WriteLine("Yes");
            //}
            //else
            //{
            //    Console.WriteLine("No");
            //}
            //Console.WriteLine(workHours - h);


        }
    }
}
