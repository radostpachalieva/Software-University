using System;

//Problem 14.	* Current Date and Time
//Create a console application that prints the current date and time. Find in Internet how.


namespace _14.CurrentDateTime
{
    class CurrentDateTime
    {
        static void Main(string[] args)
        {
            // Way 1: Common
            DateTime now = DateTime.Now;
            Console.WriteLine(now);

            // Way 2: Using DateTime Formats /http://www.dotnetperls.com/datetime-format/
            DateTime time = DateTime.Now;
            string format = "ddddd d MMMMM yyyy HH:mm ";
            Console.WriteLine(time.ToString(format));
 

            //These are for me
            Console.WriteLine(now.ToString("d"));
            Console.WriteLine(now.ToString("D"));
            Console.WriteLine(now.ToString("f"));
            Console.WriteLine(now.ToString("F"));
            Console.WriteLine(now.ToString("g"));
            Console.WriteLine(now.ToString("G"));
            Console.WriteLine(now.ToString("m"));
            Console.WriteLine(now.ToString("M"));
            Console.WriteLine(now.ToString("o"));
            Console.WriteLine(now.ToString("O"));
            Console.WriteLine(now.ToString("s"));
            Console.WriteLine(now.ToString("t"));
            Console.WriteLine(now.ToString("T"));
            Console.WriteLine(now.ToString("u"));
            Console.WriteLine(now.ToString("U"));
            Console.WriteLine(now.ToString("y"));
            Console.WriteLine(now.ToString("Y"));

            Console.WriteLine(now.ToLongDateString()); 
            Console.WriteLine(now.ToLongTimeString()); 
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToString());
        }
    }
}
