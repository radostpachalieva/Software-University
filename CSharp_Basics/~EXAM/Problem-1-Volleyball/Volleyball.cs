using System;

class Volleyball
{
    static void Main()
    {
        string leap = Console.ReadLine();
        uint hollidaysCount = uint.Parse(Console.ReadLine());                  // hollidaysCount
        uint weekendsHomeCount = uint.Parse(Console.ReadLine());                  // weekendsHomeCount

        int normal = 48;
        double weekendsNotHome = normal - weekendsHomeCount;
        double normalYr = ((weekendsNotHome * 3.0 / 4.0) 
            + (hollidaysCount * 2.0 / 3.0)) 
            + weekendsHomeCount;
        
        if (leap == "leap")
        {
            normalYr = normalYr + normalYr * 15 / 100;
        }
        Console.WriteLine((int)normalYr);


        //string leap = Console.ReadLine();
        //int hollidaysCount = int.Parse(Console.ReadLine());
        //int weekendsHomeCount = int.Parse(Console.ReadLine());

        //int weekendsInYear = 48;
        //int normalWeekendsCount = weekendsInYear - weekendsHomeCount;
        //double gamesCount =
        //    normalWeekendsCount * 3.0 / 4.0 +
        //    weekendsHomeCount * 1.0 +
        //    hollidaysCount * 2.0 / 3.0;
        //if (leap == "leap")
        //{
        //    gamesCount = gamesCount * 1.15;
        //}
        //Console.WriteLine((int)gamesCount);
    }
}
