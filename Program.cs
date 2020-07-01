using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProgram
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Multiplication has greater priority
            Console.WriteLine(1 + 2 * 3);

            // Forcing priority using parentheses
            Console.WriteLine((1 + 2) * 3);

            // Normal text
            Console.WriteLine("I have started to program");

            // Also normal text
            Console.WriteLine(" in C#.");

            // Joining two texts using plus sign
            Console.WriteLine("I have started to program" + " in C#.");

            // Multiline output
            Console.WriteLine("First line\r\nSecond line");

            // I prefer specifying "Enter" in more human form
            Console.WriteLine("First line" + Environment.NewLine + "Second line");

            // Text containing a quote
            Console.WriteLine("The letter started so sweet: \"My Darling\"");

            // Unicode characters, in this case Greek beta
            Console.WriteLine("If the font knows, here is Greek beta: \u03B2");

            // Backslashes themselves need to be doubled
            Console.WriteLine("Path to desktop on my computer: " + "C:\\Users\\sjwvuie\\Desktop");

            // Bob Dylan...
            Console.WriteLine(@"
                Yes, and how many times
                can a man turn his head
                and pretend
                that he just doesn't see?
                ");

            // Pay special attention when mixing texts with numbers!
            Console.WriteLine(
                @"Senior math test
                ==================

                One and one is:");
            Console.WriteLine("a) " + 1 + 1);
            Console.WriteLine("b) " + (1 + 1));
            Console.WriteLine("c) " + "mostly fun");

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
