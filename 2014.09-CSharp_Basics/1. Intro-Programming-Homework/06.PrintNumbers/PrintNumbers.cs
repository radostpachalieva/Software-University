using System;

//Problem 6.	Print Numbers
//Write a program to print the numbers 1, 101 and 1001, each at a separate line.
//Name the program correctly. You should submit in your homework the Visual Studio project
//holding the source code of the PrintNumbers program.


namespace _06.PrintNumbers
{
    class PrintNumbers
    {
        static void Main()
        {

            // Way 1
            string value1 = "1";
            string value2 = "0";

            Console.WriteLine("{0}",
                value1,
                value2);
            Console.WriteLine("{0}{1}{0}",
                value1,
                value2);
            Console.WriteLine("{0}{1}{1}{0}",
                value1,
                value2);
            Console.WriteLine();


            // Way 2: Using "@" (http://stackoverflow.com/questions/5821163/how-to-split-writeline-over-multiple-lines)
            Console.WriteLine(@"1 
101 
1001");
            Console.WriteLine();


            // Way 3: Using "Environment.NewLine"
            var Numbers = new[] { "1", "101", "1001" };
            Console.WriteLine(String.Join(Environment.NewLine, Numbers));
            Console.WriteLine();

            // Way 4: Using "\n" which inserts new line (http://stackoverflow.com/questions/5821163/how-to-split-writeline-over-multiple-lines)
            Console.WriteLine("{0}\n{1}\n{2}", 1, 101, 1001);
            Console.WriteLine();

            // Way 5: Common1
            int value01 = 1;
            int value02 = 101;
            int value03 = 1001;
            Console.WriteLine(value01);
            Console.WriteLine(value02);
            Console.WriteLine(value03);
            Console.WriteLine();

            // Way 5: Common2
            Console.WriteLine(1);
            Console.WriteLine(101);
            Console.WriteLine(1001);

        }
    }
}
