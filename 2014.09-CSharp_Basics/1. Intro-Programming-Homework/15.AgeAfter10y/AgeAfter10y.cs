using System;

//Problem 15.	* Age after 10 Years
//Write a program to read your birthday from the console and print how old you are now and how old you will be
//after 10 years.


namespace _15.AgeAfter10y
{
    class AgeAfter10y
    {
        static void Main()
        {
            // 
            string date;                                                            // Defines a string for input
            DateTime db;                                                            // Defines date of birth variable
            Console.WriteLine("Enter a date in format (DD.MM.YYYY): ");             // Input Date of birth
            date = Console.ReadLine();                                              // Assign the input date to string
            db = Convert.ToDateTime(date);                                          // Converts string to DateTime
            DateTime today = DateTime.Today;                                        // Defining today variable = today
            int age = today.Year - db.Year;                                         // Defining and calculating age variable
            if (today < db.AddYears(age)) age--;                                    // Checking if today is before my bd in the year
                                                                                    // If yes, it means year = year - 1
            Console.WriteLine("You are now {0} years old", age);                    // Output jfyi
            int agePlusTen = age + 10;                                              // Calculating age after 10 years
            Console.WriteLine("In 10 years you will be {0} years old!", agePlusTen);// Output the result
        }
    }
}
