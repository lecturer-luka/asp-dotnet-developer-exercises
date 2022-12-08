/*
 * Create a simple program that will accept one sentence input.
 * Using a for loop use input characters to arrange them in ascending order
 */

#region This is here only to help you plan your input and sorting

string sentence;
char[] array_of_characters;
int i, j, length;

#endregion

Console.Write("Enter a sentence: ");
sentence = Console.ReadLine();
length = sentence.Length;
array_of_characters = sentence.ToCharArray(0, length);

// Insert your code logic below using for loop
// ==================================================================



// This is only here to stop the program before exiting
Console.ReadKey();