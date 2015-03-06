using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 11.	Bank Account Data
//A bank account has a holder name (first name, middle name and last name), available amount of money (balance), 
//bank name, IBAN, 3 credit card numbers associated with the account. Declare the variables needed to keep the information 
//for a single bank account using the appropriate data types and descriptive names.


namespace _11.BankAccount_Data
{
    class BankAccount_Data
    {
        static void Main(string[] args)
        {
            Console.Title = "Problem 11. Bank Account Data";
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string firstName = "Tyrion";
            string middleName = "Lannister";
            string lastName = "Lannister";
            decimal balance = 6844455.65m;
            char symbol = '€';
            string bankName = "Iron Bank of Braavos";
            object numIBAN = "BR11 AAVO 7921 5921 0841 92";  //IBAN се състои от букви и цифри
            object codeBIC = "BGBR11V0S";                    //BIC се състои от букви и цифри
            long creditCardNumber = 1234567891111;

            object objName = (firstName + " " + middleName + " " + lastName);
            object objMoney = (balance + "" + (char)symbol);
            Console.WriteLine(" Bank account record: \n \n Holder: {0} \n Bank: {1} \n Balance: {2} \n IBAN: {3} \n BIC: {4}", objName, bankName, objMoney, numIBAN, codeBIC);
            Console.WriteLine();
            Console.WriteLine(" Card Numbers: \n Visa: {0}", creditCardNumber);
            Console.WriteLine();

        }
    }
}
