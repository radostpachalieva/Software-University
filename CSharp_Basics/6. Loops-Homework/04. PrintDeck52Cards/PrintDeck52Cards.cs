using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 4.	Print a Deck of 52 Cards
//Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). 
//The cards should be printed using the classical notation (like 5♠, A♥, 9♣ and K♦). The card faces should start from 2 to A. 
//Print each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and 
//a switch-case statement.
//output
//2♣ 2♦ 2♥ 2♠
//3♣ 3♦ 3♥ 3♠
//…
//K♣ K♦ K♥ K♠
//A♣ A♦ A♥ A♠


namespace _04.PrintDeck52Cards
{
    class PrintDeck52Cards
    {
        static void Main(string[] args)
        {

            //Arrays
            string[] cards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            int[] colors = { 3, 4, 5, 6 };      // ♣ ♦ ♥ ♠

            foreach (var card in cards)
            {
                foreach (var color in colors)
                {
                    Console.Write(card);
                    Console.Write((char)color + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
