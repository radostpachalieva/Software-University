using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 2.	Print Company Information
//A company has name, address, phone number, fax number, web site and manager. 
//The manager has first name, last name, age and a phone number. Write a program 
//that reads the information about a company and its manager and prints it back on the console.


namespace _02.PrintCompanyInformation
{
    class PrintCompanyInformation
    {
        static void Main(string[] args)
        {
            Console.Write("Company name: ");
            string companyName = (Console.ReadLine());
            Console.Write("Company address: ");
            string companyAddress = (Console.ReadLine());
            Console.Write("Phone number: ");
            string phoneNumber = (Console.ReadLine());
            Console.Write("Fax number: ");
            string faxNumber = (Console.ReadLine());
            Console.Write("Web site: ");
            string webSite = (Console.ReadLine());

            Console.Write("Manager first name: ");
            string managerFirstName = (Console.ReadLine()); 
            Console.Write("Manager last name: ");
            string managerLastName = (Console.ReadLine()); 
            Console.Write("Manager age: ");
            int managerAge = int.Parse(Console.ReadLine());
            Console.Write("Manager phone: ");
            string managerPhone = (Console.ReadLine());

            Console.Write("-----------------------------\t\n\t\n");
            Console.Write("{0}\t\nAdress: {1}\t\nTel. {2}\t\nFax: {3}\t\nWeb site: {4}\t\n\t\nManager: {5} {6} (age: {7}, tel. {8})\t\n",
                companyName, companyAddress, phoneNumber, faxNumber, webSite, 
                managerFirstName, managerLastName, managerAge, managerPhone);
        }
    }
}
