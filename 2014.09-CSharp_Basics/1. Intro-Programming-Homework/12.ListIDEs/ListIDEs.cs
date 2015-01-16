using System;
using System.Text;

//Problem 12.	Development Environments
//Perform a research (e.g. in Google or Wikipedia) and provide a short list with popular 
//development environments (IDEs) like Visual Studio. Write in a text file called “list-of-IDEs.txt” 
//at least five IDEs along with 2-3 sentences about each of them. Use English.


class ProgrammingLanguages
{
    static void Main()
    {
        string topicInfo = "Problem 12. Development Environments\n\nPerform a research (e.g. in Google or Wikipedia) and provide a short list with popular development environments (IDEs) like Visual Studio. Write in a text file called “list-of-IDEs.txt” at least five IDEs along with 2-3 sentences about each of them. Use English.\r\n";
        string topicDE = "A development environment is a collection of procedures and tools for developing, testing and debugging an application or program. In software development, the development environment is a set of processes and tools that are used to develop a source code or program.\r\n";
        string topicTOP = "C#-Visual Studio, SharpDevelop\nJava-Eclipse, NetBeans, IDEA\nObjective-C-Xcode\nC/C++-Visual Studio, Vim\nPL/SQL-RapidSQL, Oracle SQLDeveloper\nPHP-Eclipse, NetBeans\nPython-Eclipse\nPerl-Padre\nRuby-TextMate\nHaskell-Vim\nFortran-Vim\r\n";
        string topicVS = "Visual Studio products cover languages like C++, C# and VB.NET. Visual Studio has an advantage when it comes to programming. This IDE is mostly used by corporate programmers to produce .NET code. Microsoft Visual Studio offers a multitude of editions for developing, testing, and deploying applications for the web, desktop, mobile, and even game consoles. Languages Supported: Ajax, ASP.NET, XAML, JavaScript, dynamic HTML, DHTML, Visual Basic, Visual C#, Visual C++, Visual F#, JScript.\r\n";
        string topicNBeans = "Netbeans is extremely extensible via its plugin-centric design, allowing you to add additional language syntax support and libraries, among other things. Netbeans is free. An intuitive, drag-and-drop interface with project templates, binary and static libraries, and many useful functions to make your life simpler. NetBeans is a functional IDE for editing existing projects, building on templates or building from scratch on most leading platforms. Languages Supported: C, C++, C++11, Java, Fortran, Assembler, Ruby, HTML5, PHP.\r\n";
        string topicEclipse = "Eclipse is another free open source IDE which specializes in heavy Java development. It has almost all the features that an advance IDE needs. Though being specialized in Java it also supports C, C++,Python, using plug-ins. It is built on its own GUI library. Languages Supported: C, C++, Python, Perl, PHP, Java, Ruby and more.\r\n";
        string topicCBlocks = "Code::Blocks is exceptionally lightweight in size, yet still quite functional and feature-rich IDE. Code::Blocks also takes advantage of multi-core compiling. It can be used freely by anyone. Code::Blocks, an extensible and fully configurable IDE designed to support its users most demanding needs, supports C, C++ and Fortran. It provides a consistent look, feel and operation across all platforms for seamless transitions between work spaces, and it’s built around a plug-in framework, providing a multitude of options for extension. It’s open-source and offers cross-platform functionality with no hidden costs. Languages Supported: C, C++, Fortran.\r\n";
        string topicCodeLite = "An Open-Source, cross-platform IDfor C+ and C++ coding languages, CodeLite works on all major platforms. CodeLite offers a variety of features, including two built-in completion engines, compilers, refactoring, code navigation and more. Languages Supported: C, C++.\r\n";
        string topicKomodo = "Komodo is a comprehensive IDE that supports all major programming languages, providing a single tool that meets your development needs across the spectrum. Komodo provides a clean, intuitive interface with advanced editing capabilities and integrated tools for the most functionality. Languages Supported: Python, PHP, Ruby, Perl, HTML, CSS, JavaScript, C, C++.\r\n";
        string topicAptana = "If web and scripting languages are more of your style, Aptana is well suited for the task. Even the studio itself is available as a plugin for Eclipse if you prefer the way Aptana handles your work and want to combine it with a more comprehensive IDE. Aptana Studio is based on Eclipse and is available as standalone on Windows, Mac & Linux, or as a plug-in for Eclipse. It’s been completely re-built to provide a faster and seamless environment for developing and testing an entire web application using a single environment. Aptana Studio 3 supports all the major browser technology specs, eliminating compatibility and testing challenges to speed your time to deployment. Languages Supported: HTML5, CSS3, JavaScript, Ruby, Rails, PHP and Python.\r\n";
        string topickate = "Kate is exactly how the website describes it, a text editor. Not to be looked down upon as it does a lot more than a regular text edit can do and that is what makes this an indispensable product.\r\n";
        string topicgedit = "gedit is the official editor of the gnome desktop and comes installed once the system is setup. Very useful for the user that is casually editing code and not undertaking major projects. This would be a good companion to Netbeans or Eclipse.\n";


        Console.SetWindowSize(100, 50);
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.ForegroundColor = ConsoleColor.Blue;


        PrintLines(topicInfo);

        Console.WriteLine("Development Environment");
        PrintLines(topicDE);

        Console.WriteLine("What are the most popular IDEs per language?");
        PrintLines(topicTOP);

        Console.WriteLine("Microsoft Visual Studio");
        PrintLines(topicVS);

        Console.WriteLine("NetBeans");
        PrintLines(topicNBeans);
        
        Console.WriteLine("Eclipse");
        PrintLines(topicEclipse);

        Console.WriteLine("Code::Blocks");
        PrintLines(topicCBlocks);

        Console.WriteLine("CodeLite");
        PrintLines(topicCodeLite);

        Console.WriteLine("Komodo IDE");
        PrintLines(topicKomodo);

        Console.WriteLine("Aptana Studio");
        PrintLines(topicAptana);

        Console.WriteLine("kate");
        PrintLines(topickate);

        Console.WriteLine("gedit");
        PrintLines(topicgedit);


        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(@"Sources
http://blog.profitbricks.com/top-integrated-developer-environments-ides/
http://www.comptalks.com/top-10-ides-available-for-programmers/
http://programmers.stackexchange.com/questions/5972/what-are-the-most-popular-ides-per-language
http://www.techrepublic.com/blog/five-apps/five-integrated-development-environment-applications/
http://hackaday.com/2010/08/24/top-5-integrated-development-environments/
http://www.techopedia.com/definition/16376/development-environment
http://en.wikipedia.org/wiki/Comparison_of_integrated_development_environments
http://wiki.wxwidgets.org/List_of_Integrated_Development_Environments
http://mashable.com/2010/10/06/ide-guide/
http://en.wikipedia.org/wiki/Integrated_development_environment
http://en.wikipedia.org/wiki/Development_environment_%28software_development_process%29");
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