/*
 * With the help of basic variables and the Console.ReadLine() command save two values, then assign variable "a" the entered value of variable "b" and assign variable "b" the entered value of variable "a"
 */

// Here we have basic logic to insert data
// (in this example input validation is not required, the user is expected to enter an integer values)
Console.Write("Enter a value for variable \"a\": ");
int a = int.Parse(Console.ReadLine());
Console.Write("Enter a value for variable \"b\": ");
int b = int.Parse(Console.ReadLine());


Console.WriteLine("\n\nBefore:\na = {0}\nb = {1}", a, b);

// Insert your code logic here to replace values between variables

Console.WriteLine("\nAfter:\na = {0}\nb = {1}", a, b);


// This is only here to stop the program before exiting
Console.ReadKey();