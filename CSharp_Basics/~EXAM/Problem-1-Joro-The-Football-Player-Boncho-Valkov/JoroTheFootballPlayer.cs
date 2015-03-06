using System;

class JoroTheFootballPlayer
{
    static void Main()
    {
        string leap = Console.ReadLine();
        int hollidaysCount = int.Parse(Console.ReadLine());         // p
        int weekendsHomeCount = int.Parse(Console.ReadLine());      // h

        int weekendsInYear = 52;                                    // normal
        int normalWeekendsCount = weekendsInYear - weekendsHomeCount;       // normal = 52 - home
        double gamesCount =
            normalWeekendsCount * 2d / 3d +                         // normal *2/3  -------> decimal!
            weekendsHomeCount * 1d +                                // home that we -! *1 once at Saturday
            hollidaysCount / 2d;                                    // 1/2 hollidays 
        if (leap == "t")                                            // if it's leap year +3
        {
            gamesCount = gamesCount + 3;
        }
        Console.WriteLine((int)gamesCount);                         // if not
    }
}
