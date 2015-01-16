using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 5.	Boolean Variable
//Declare a Boolean variable called isFemale and assign an appropriate value 
//corresponding to your gender. Print it on the console.


namespace _05.BooleanVariable
{
    class BooleanVariable
    {
        static void Main(string[] args)
        {
            Console.Title = "Problem 5. Boolean Variable";
            bool isFemale;
            Console.WriteLine("What is your gender (\"male\" or \"female\"): ");
            string myGarden = Console.ReadLine();
            if (myGarden == "female")
            {
                isFemale = true;
            }
            else
            {
                isFemale = false;
            }
            Console.WriteLine("Are you female: " + isFemale);
        }
    }
}
