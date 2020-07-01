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
            // Declaration of a variable to store text
            string message;

            // Storing a value in prepared variable (assignment statement)
            message = "I can't live with you.";

            // Another variable (initialized with some value)
            string anotherMessage = "I can't live without you.";

            // Output of variables
            Console.WriteLine(message);
            Console.WriteLine(anotherMessage);

            // Variable for storing number (with initial value)
            int number = -12;

            // Output of value of the variable
            Console.WriteLine("Value of the variable: " + number);

            // Precalculation of result (into variable)
            int sum = 1 + 1;

            // Output to the user
            Console.WriteLine(
@"Answer to Senior math test
=========================

One and one is: " + sum);

            // 1. Solution
            // Values to be summed
            int firstNumber = 42;
            int secondNumber = 11;

            // Calculating
            int sum2 = firstNumber + secondNumber;

            // Output
            Console.WriteLine("Sum is: " + sum2);

            // 2. Solution
            // Declaring all variables at once
            int thirdNumber, fourthNumber, newSum;

            // Values to be summed
            thirdNumber = 42;
            fourthNumber = 11;

            // Calculating
            newSum = thirdNumber + fourthNumber;

            // Output
            Console.WriteLine("Calculated another way: " + newSum);

            // Data in variables
            string club1 = "FC Liverpool";
            string club2 = "Manchester United";
            int goals1 = 3;
            int goals2 = 2;

            // Output of match result
            Console.WriteLine("" +
                "Match " + club1 + " - " + club2 + " ended with result " + goals1 + ":" + goals2 + ".");

            // IN CODE, decimal separator is always DOt regardless of computer language settings
            double piApproximately = 3.14;

            // Pi is already available in C#
            double piMorePrecisely = Math.PI;

            // Decimal numbers have always limited precision
            double notCompletelyOne = 0.999999999999999999;

            // Outputs
            Console.WriteLine("Pi value from our code: " + piApproximately);
            Console.WriteLine("Pi value from C#: " + piMorePrecisely);
            Console.WriteLine("This should not be exact one: " + notCompletelyOne);

            // Two logical (Boolean) variables
            bool thePrettiestGirlLovesMe = true;
            bool iAmHungry = false;

            // Use exclamation mark to negate logical value
            bool iAmNotHungry = !iAmHungry;

            // Output
            Console.WriteLine("She loves me: " + thePrettiestGirlLovesMe);
            Console.WriteLine("I am hungry: " + iAmHungry);
            Console.WriteLine("I am not hungry: " + iAmNotHungry);

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
