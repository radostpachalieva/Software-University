﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 6.	Strings and Objects
//Declare two string variables and assign them with “Hello” and “World”. Declare an object variable 
//and assign it with the concatenation of the first two variables (mind adding an interval between). 
//Declare a third string variable and initialize it with the value of the object variable 
//(you should perform type casting).


namespace _06.StringsАndObjects
{
    class StringsАndObjects
    {
        static void Main(string[] args)
        {
            Console.Title = "Problem 6. Strings and Objects";

            string hello = "Hello";
            string world = "World";
            object helloWorld = hello + " " + world;

            string helloWorldCast = (string)helloWorld;  // string helloWorldCast = helloWorld.ToString();

            Console.WriteLine(helloWorldCast);
        }
    }
}
