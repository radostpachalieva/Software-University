using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2_Book_Orders
{
    class Book_Orders
    {
        static void Main(string[] args)
        {


            int numberOfOrders = int.Parse(Console.ReadLine());
            double finalPrice = 0;
            int allBoughtBooks = 0;

            for (int i = 0; i < numberOfOrders; i++)
            {
                int packets = int.Parse(Console.ReadLine());
                int booksPerPacket = int.Parse(Console.ReadLine());
                double bookPrice = double.Parse(Console.ReadLine());

                int allOrderBooks = packets * booksPerPacket;
                allBoughtBooks += allOrderBooks;

                double discount = 0;
                if (packets >= 10 && packets < 110)
                {
                    discount = (packets / 10) + 4;
                }
                else if (packets >= 110)
                {
                    discount = 15;
                }
                double priceWithDiscount = bookPrice * (100 - discount) / 100;
                finalPrice += priceWithDiscount * allOrderBooks;
            }
            Console.WriteLine(allBoughtBooks);
            Console.WriteLine("{0:F2}", finalPrice);




            ////================================================================

            //int ordersCount = int.Parse(Console.ReadLine());

            //int totalBooks = 0;
            //double totalPrice =0;

        
            //for (int i = 0; i < ordersCount; i++)
            //{
            //    int numberOfPacks = int.Parse(Console.ReadLine());
            //    int bookPerPack = int.Parse(Console.ReadLine());
            //    double bookPrice = double.Parse(Console.ReadLine());
            //    totalBooks += numberOfPacks * bookPerPack;

            //    double discount = 1;

            //    if (numberOfPacks>=10 && numberOfPacks<=109)
            //    {
            //        discount = (100 - (numberOfPacks / 10 + 4)) / 100;
            //    }
            //    else if (numberOfPacks>109)
            //    {
            //        discount = (100 - 15)/ 100;
            //    }
                
            //    totalPrice += numberOfPacks *bookPerPack *bookPrice *discount;

            //}

            //Console.WriteLine(totalBooks);
            //Console.WriteLine("{0:F2}", totalPrice);

        }
    }
}
