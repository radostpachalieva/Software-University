using System;
using System.Text;

//Problem 11.	Programming Languages
//Perform a research (e.g. in Google or Wikipedia) and provide a short list with information about 
//the most popular programming languages. How similar are they to C#? How do they differ from C#? 
//Write in a text file called “programming-languages.txt” at least five languages along with 2-3 
//sentences about each of them. Use English.



class ProgrammingLanguages
{
    static void Main()
    {
        string topicInfo = "Problem 11. Programming Languages \n\nPerform a research (e.g. in Google or Wikipedia) and provide a short list with information about the most popular programming languages. How similar are they to C#? How do they differ from C#? Write in a text file called “programming-languages.txt” at least five languages along with 2-3 sentences about each of them. Use English.\n\nThere is lost of information about the most popular programming languages. Almost in every article we can see that the tops are same languages.\r\n";
        string topicJava = "It's a deeply featured class-based, object-oriented programming language that's designed to be portable and workable on as many platforms as possible. Java gets a lot of its syntax from C or C++ languages. Uses: Applications and Program development, Game development, Internet and web page development and more.\r\n";
        string topicCSharp = "C# is a multi-paradigm language. Combining principles from C and C++, C# is a general-purpose language used to develop software for Microsoft and Windows platforms. C# is very similar to Java in terms of capabilities. It has been said that C# combines the robustness of C++ with the advanced features of Java. Uses: Applications and Program development, Artificial Intelligence development, Game development and more.\r\n";
        string topicC = "A general-purpose, imperative programming language. C is the oldest and most widely used language, providing the building blocks for other popular languages, such as C#, Java, JavaScript and Python. C is mostly used for implementing operating systems and embedded applications. Uses: Applications and Program development, Artificial Intelligence development, Game development, Computer drivers or other hardware interface development and more.\r\n";
        string topicCPP = "C++ is an intermediate-level language with object-oriented programming features, originally designed to enhance the C language. It started off as a set of improvements and updates to bring C into modern applications. C++ is object-oriented features like classes to the language, along with virtual functions and templates. Uses: Applications and Program development, Artificial Intelligence development, Game development and more.\r\n";
        string topicObjectiveC = "Objective-C is a general-purpose, object-oriented programming language used by the Apple operating system. It powers Apple's OS X and iOS, as well as its APIs, and can be used to create iPhone apps, which has generated a huge demand for this once-outmoded programming language. The purpose of developing Objective-C programming language was to address the deficiencies in C language.\r\n";
        string topicPython = "Python is a high-level, server-side scripting language. It's considered a fairly easy language due to its readability and compact syntax, meaning developers can use fewer lines of code to express a concept than they would in other languages. Python is usually used and referred to as a scripting language, allowing programmers to churn out large quantities of easily readable and functional code in short periods of time, but it's also dynamic, and supports object-oriented, procedural, and functional programming styles, among others. Thanks to its flexibility, Python is one of the most widely used high-level programming languages today. Uses: Internet and web page development, Mobile apps, Script development and more.\r\n";
        string topicPHP = "PHP (Hypertext Preprocessor) is one of the most widely used languages used to develop dynamic websites. It is a server-side scripting language which means that PHP code is processed on the server and end result is sent to the user of the website in the form of plain HTML. PHP is an open-source language which means that there are thousands of already built modules that can be modified to achieve the desired functionality. Uses: Internet and dynamic web page development, App development and more.\r\n";
        string topicJS = "JavaScript is a client side programming language that runs inside a client browser and process commands on client computer rather than server which results in decreased load on server and increased application’s execution speed. It is one of the fundamental technologies on which the web as we know it is based. JavaScript exists outside of the browser as well, but largely in the context of connected applications and services. The language itself is dynamic, and gives programmers the flexibility to use object-oriented programming styles (as the language itself is mostly object oriented) as well as functional and imperative ones. It derives much of its syntax from C. Uses: Internet and web page development, It can be used across multiple web browsers, For developing interactive or animated web functions, Game development Desktop applications and more.\r\n";

        Console.SetWindowSize(100, 50);
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.ForegroundColor = ConsoleColor.Blue;


        PrintLines(topicInfo);

        Console.WriteLine("Java: ");
        PrintLines(topicJava);

        Console.WriteLine("C# (C Sharp): ");
        PrintLines(topicCSharp);

        Console.WriteLine("C Language: ");
        PrintLines(topicC);

        Console.WriteLine("C++: ");
        PrintLines(topicCPP);

        Console.WriteLine("Objective-C: ");
        PrintLines(topicObjectiveC);

        Console.WriteLine("Python: ");
        PrintLines(topicPython);

        Console.WriteLine("PHP: ");
        PrintLines(topicPHP);

        Console.WriteLine("JavaScript: ");
        PrintLines(topicJS);

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(@"Sources
1. http://langpop.com/,
2. http://blog.codeeval.com/codeevalblog/2014#.VBfy2GPELLx=,
3. http://mashable.com/2014/01/21/learn-programming-languages/,
4. http://lifehacker.com/five-best-programming-languages-for-first-time-learners-1494256243
5. http://pastebin.com/Jqh8wiFb");
    }

    static void PrintLines(string content)
    {
        Console.ForegroundColor = ConsoleColor.White;
        int lineLimit = 80;
        StringBuilder wordLine = new StringBuilder("");
        string[] topic = content.Split(' ');
        for (int index = 0; index < topic.Length; index++)
        {
            wordLine.Append(topic[index]);
            wordLine.Append(" ");
            if ((wordLine.Length > lineLimit) || (index == topic.Length - 1))
            {
                Console.WriteLine(wordLine);
                wordLine.Clear();
            }
        }
        Console.ForegroundColor = ConsoleColor.Blue;
    }

}