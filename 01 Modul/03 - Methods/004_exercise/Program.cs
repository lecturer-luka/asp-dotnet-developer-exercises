using System.Collections;

/*
 * Using only methods, create a simple application inside the Program class to solve the problem of organizing and printing data of the same types
 * 
 */

namespace _004_exercise;

internal class Program
{
    static void Main(string[] args)
    {

        ArrayList first_unorganized_list = new ArrayList()
        {
            "Mike",
            "Ana",
            0,
            "(",
            22,
            null,
            107.55F,
            "More than 50% off today only!",
            205.33D,
            -30,
            "Someone ate my chocolate...",
            104,
            "",
            "",
            ',',
            true,
            true,
            (-11 + 100),
            -30,
            "Weekend soon :)",
            0,
            (45+2),
            false,
            "",
            "Quantity discount",
            true,
            '.'
        };

        ArrayList second_unorganized_list = new ArrayList()
        {
            "Programmer",
            "!",
            ')',
            -222222222,
            null,
            false,
            107.55F,
            205.33D,
            104,
            "",
            "",
            true,
            "Today is a beautiful and sunny day!",
            true,
            -11,
            -30,
            0,
            "",
            '!',
            'k',
            4284729847238947274,
            '9',
            (45+2-1000),
            "Where is my method?",
            false,
            "",
            0,
            true,
            ".",
            1000000000.00000000000000
        };


        List<int> list_of_integers = new List<int>();
        List<decimal> list_of_decimal_numbers = new List<decimal>();
        List<char> list_of_character = new List<char>();
        List<string> list_of_strings = new List<string>();
        List<bool> list_of_booleans = new List<bool>();

        /*
         * Help:
         * Step 1: pass the list you want to organize as an argument to the method
         * Step 2: inside the method it is possible to create a loop that will iterate through the individual value
         * Step 3: for each iteration it is possible to check the data type
         * Step 4: if the value is null, skip it. Save all other values in the corresponding lists
         * Step 5: use documentation for type comparison and type conversion 
         * 
         * Step 6: after the process of organizing the list is finished, it is necessary to offer the user some options
         * Available options for choosing to print the list:
         *      Option yes - selecting this option opens additional options:
         *                  1 - print everything from the list of integers
         *                  2 - print everything from the list of decimal numbers
         *                  3 - print everything from the list of string
         *                  4 - print everything from the list of characters
         *                  5 - print everything from the list of booleans
         *
         *      Option no - exits and ends the program
         * 
         * 
         * 
         * Type comparison documentation: https://learn.microsoft.com/en-us/dotnet/api/system.object.gettype?view=net-6.0
         * Type conversion documentation: https://learn.microsoft.com/en-us/dotnet/api/system.convert?view=net-6.0
         */


        // This is only here to stop the program before exiting
        Console.ReadKey();
    }

    // Insert your methods inside class Program
    // ==================================================================
}