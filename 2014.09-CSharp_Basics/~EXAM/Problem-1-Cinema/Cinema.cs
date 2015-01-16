using System;

class Cinema
{
    static void Main(string[] args)
    {
        System.Threading.Thread.CurrentThread.CurrentCulture =
    System.Globalization.CultureInfo.InvariantCulture;

        string movieType = Console.ReadLine();
        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());

        decimal price = 0;

        switch (movieType)
        {
            case "Premiere":
                price = 12;
                break;
            case "Normal":
                price = 7.5m;
                break;
            case "Discount":
                price = 5;
                break;
        }

        decimal result = rows * cols * price;
        Console.WriteLine("{0:F2} leva", result);
        
        //-------------------------------------------------------------------------------
        
        //string typeOfProjection = Console.ReadLine();
        //int rowsStays = int.Parse(Console.ReadLine());
        //int colsStays = int.Parse(Console.ReadLine());

        //string premiere = "Premiere";
        //string normal = "Normal";
        //string discount = "Discount";
        //double costs = 0;

        //if (typeOfProjection == premiere)
        //{
        //    costs = 12.00 * rowsStays * colsStays;
        //    Console.WriteLine("{0:0.00} leva", costs);
        //}

        //else if (typeOfProjection.Equals(normal))
        //{
        //    costs = 7.50 * rowsStays * colsStays;
        //    Console.WriteLine("{0:0.00} leva", costs);
        //}

        //else if (typeOfProjection.Equals(discount))
        //{
        //    costs = 5.00 * rowsStays * colsStays;
        //    Console.WriteLine("{0:0.00} leva", costs);
        //}

    }
}