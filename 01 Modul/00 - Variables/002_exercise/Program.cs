/*
 * Using basic variables and arithmetic operators write a simple program that takes distance and time 
 * as input and displays speed km/h and mph.
 */

float distance, hour, minutes, seconds;
float kilometres_per_hour = 0.0F, miles_per_hour = 0.0F;

// Here we have basic logic to insert data
// (in this example input validation is not required, the user is expected to enter an integer or float value type)
Console.Write("Enter the distance (meters): ");
distance = Convert.ToSingle(Console.ReadLine());
Console.Write("Enter the time (hour): ");
hour = Convert.ToSingle(Console.ReadLine());
Console.Write("Enter the time (minutes): ");
minutes = Convert.ToSingle(Console.ReadLine());
Console.Write("Enter the time (seconds): ");
seconds = Convert.ToSingle(Console.ReadLine());


// Insert your code logic here to calculate speed in kilometers per hour and miles per hour



// Here we have data output
Console.WriteLine("Your speed in \"km/h\" is {0}", kilometres_per_hour);
Console.WriteLine("Your speed in \"mph\" is {0}", miles_per_hour);


// This is only here to stop the program before exiting
Console.ReadKey();