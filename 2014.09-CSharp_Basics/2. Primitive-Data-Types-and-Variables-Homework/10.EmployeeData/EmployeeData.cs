using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 10.	Employee Data
//A marketing company wants to keep record of its employees. Each record would have the following characteristics:
//•	First name
//•	Last name
//•	Age (0...100)
//•	Gender (m or f)
//•	Personal ID number (e.g. 8306112507)
//•	Unique employee number (27560000…27569999)
//Declare the variables needed to keep the information for a single employee using appropriate primitive data types. 
//Use descriptive names. Print the data at the console.


namespace _10.EmployeeData
{
    class EmployeeData
    {
        static void Main(string[] args)
        {
            Console.Title = "Problem 10. Employee Data";

            // Declare the variables
            string firstName;
            string lastName;
            int age;
            char gender;
            ulong personalIDnumber;
            uint employeeNumber;

            // Data input / read
            Console.WriteLine("Enter your First name: ");
            firstName = Console.ReadLine();
            Console.WriteLine("Enter your Last name: ");
            lastName = Console.ReadLine();
            Console.WriteLine("Enter your Age: ");
            age = int.Parse(Console.ReadLine());                // or with [int no = (int)Convert.ToInt32(Console.ReadLine());]
            Console.WriteLine("Enter your Gender: ");
            gender = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Personal ID number (e.g. 8306112507): ");
            personalIDnumber = ulong.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Unique employee number (27560000…27569999): ");
            employeeNumber = uint.Parse(Console.ReadLine());

            // Output the string variables
            Console.WriteLine("Information for a single employee\nFirst name: {0}\nLast name: {1}", firstName, lastName);

            // Writeline Age!! Check!
            if (age > 80 || age < 18) // You can input only from 18 to 80
            {
                Console.WriteLine("Age: Not valid");
            }
            else
            {
                Console.WriteLine("Age: " + age);
            }

            // Writeline Gender!! Check!
            if (gender == '\u006d' || gender == '\u0066') // You can input only "m" or "f"
            {
                Console.WriteLine("Gender: " + gender);
            }
            else
            {
                Console.WriteLine("Gender: Not valid");
            }

            // ---------------------------------------------------------------
            // WriteLine Personal ID number!! Check|! (e.g. 8306112507) How? I will leave it for the next lessons. :(
            // ---------------------------------------------------------------

            // Output the Personal ID number and Unique employee number
            Console.WriteLine("Personal ID number: {0}", personalIDnumber);

            // WriteLine Unique employee number!! Check! (27560000…27569999)
            if (employeeNumber >= 27560000 && employeeNumber <= 27569999) // You can input only from(and) 27560000 to 27569999
            {
                Console.WriteLine("Unique employee number: " + employeeNumber);
            }
            else
            {
                Console.WriteLine("Unique employee number: Not valid");
            }

        }
    }
}
