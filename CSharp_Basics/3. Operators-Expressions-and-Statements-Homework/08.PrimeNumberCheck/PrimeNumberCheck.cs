using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 8.	Prime Number Check
//Write an expression that checks if given positive integer number n (n ≤ 100) is prime 
//(i.e. it is divisible without remainder only to itself and 1). 
//Examples:
//  n	    Prime?
//  1	    false
//  2	    true
//  3	    true
//  4	    false
//  9	    false
//  97  	true
//  51  	false
//  -3  	false
//  0	    false

// From http://www.introprogramming.info/intro-csharp-book/read-online/glava3-operatori-i-izrazi/
//Напишете програма, която проверява дали дадено число n (1 < n < 100) е просто 
//(т.е. се дели без остатък само на себе си и на единица).

//Прочетете за цикли в Интернет. Използвайте цикъл и проверете числото за делимост 
//на всички числа от 1 до корен квадратен от числото. В конкретната задача, 
//тъй като ограничението е само до 100, можете предварително да намерите простите числа 
//от 1 до 100 и да направите проверки дали даденото число n e равно на някое от тях.

namespace _08.PrimeNumberCheck
{
    class PrimeNumberCheck
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your number: ");
            int number = int.Parse(Console.ReadLine());

            if (number <= 1)            // Checking if the number is <= 1
            {
                Console.WriteLine("This number is prime = False");
            }
            else
            {
                int primeCount = 0;

                for (int i = 1; i <= number; i++)
                {
                    if (number % i == 0)
                    {
                        primeCount++;
                    }
                }

                bool isPrime = true;

                if (primeCount > 2)
                {
                    isPrime = false;
                }

                Console.WriteLine("This number is prime = " + isPrime);


                ////--------------------------------------

                //int inputNumber = int.Parse(Console.ReadLine());
                //int[] primes;
                //
                //primes = new int[]
                //{
                //    3, 7, 11, 17, 23, 29, 37,
                //    47, 59, 71, 89, 97
                //};
                //
                //bool prime = false;
                //if (inputNumber < 0)
                //{
                //    prime = false;
                //}
                //else
                //{
                //    for (int i = 0; i < primes.Length; i++)
                //    {
                //        if (inputNumber == primes[i])
                //        {
                //            prime = true;
                //        }
                //    }
                //Console.WriteLine(prime);
            
            }
        }
    }
}
