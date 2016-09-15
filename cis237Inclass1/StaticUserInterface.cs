// Static User Interface Class.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237Inclass1
{
    static class StaticUserInterface    // Add STATIC keyword
    {
        // The methods all had to become static because the class is.
        public static int GetUserInput()       // Get and validate user input .
        {
            // Call the PrintMenu method that is private to this class.
            StaticUserInterface.PrintMenu();    /// NEW - static class cannot use keyword "this"

            // Get input from the console.
            string input = Console.ReadLine();

            // Continue to loop while the input is not a valid choice.
            while (input != "1" && input != "2")
            {
                // Output message for invalid input.
                Console.WriteLine("That is not a valid entry.");
                Console.WriteLine("Please make a valid choice.");
                Console.WriteLine();

                // Redisplay print menu.
                StaticUserInterface.PrintMenu();    /// NEW - same as above

                // Re-get user input.
                input = Console.ReadLine();
            }
            // Parse the valid user input to integer and return that value.
            return Int32.Parse(input);
        }

        // Public method to print the output to the user, called from Main.
        public static void PrintAllOutput(string allOutput)
        {
            Console.WriteLine(allOutput);
        }

        // Private method to output choices to the user.
        private static void PrintMenu()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Print list.");
            Console.WriteLine("2. Exit.");
        }
    }
}
