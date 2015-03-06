using System;
using System.Text;

//Problem 13.	C# and .NET Differences
//Describe the difference between C# and .NET Framework in 2-3 sentences. Write your description 
//in a text file called “csharp-and-dot-net-framework.txt”. Use English.



class CSharpAndDotNetFramework
{
    static void Main()
    {
        string topicInfo = "Problem 13. C# and .NET Differences\n\nDescribe the difference between C# and .NET Framework in 2-3 sentences. Write your description in a text file called \n“csharp-and-dot-net-framework.txt”. Use English.\r\n";
        string topic = ".NET is an application development framework - it contains numerous libraries containing a range of functionality. C# is a strong Object Oriented programming language that is mostly built on the .NET framework. C# is a .NET based/developed language - its a language used to develop on the .NET platform and is available through .NET framework.\r\n";

        Console.SetWindowSize(100, 50);

        PrintLines(topicInfo);

        Console.WriteLine();
        PrintLines(topic);

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(@"Sources
http://forums.asp.net/t/1958871.aspx
http://stackoverflow.com/questions/2724864/what-is-the-difference-between-c-sharp-and-net
http://forums.academy.telerik.com/20709/%D0%BF%D0%BE%D0%BC%D0%BE%D1%89-%D0%BE%D1%82%D0%BD%D0%BE%D1%81%D0%BD%D0%BE-10-%D0%B8-11-%D0%B7%D0%B0%D0%B4%D0%B0%D1%87%D0%B8-%D0%BD%D0%B0-%D0%BF%D1%8A%D1%80%D0%B2%D0%BE%D1%82%D0%BE-%D0%B4%D0%BE%D0%BC%D0%B0%D1%88%D0%BD%D0%BE-%D0%BD%D0%B0-c%23
http://forums.academy.telerik.com/19247/%D0%B7%D0%B0%D0%B4%D0%B0%D1%87%D0%B8-%D0%BE%D1%82-%D0%BF%D1%8A%D1%80%D0%B2%D0%B0-%D0%BB%D0%B5%D0%BA%D1%86%D0%B8%D1%8F
http://social.msdn.microsoft.com/Forums/vstudio/en-US/005ae8ef-79bb-4845-8671-151295b21412/difference-between-visualcnet-and-c?forum=csharpgeneral
http://msdn.microsoft.com/en-us/library/z1zx9t92.aspx");
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
    }

}