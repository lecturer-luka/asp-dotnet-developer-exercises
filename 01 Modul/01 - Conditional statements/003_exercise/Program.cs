/*
 * Using If statement write a simple program for entering and reading first name, last name and entering scores of three subjects for one student from the competition.
 * Calculate the total and percentage of the points.
 * Depending on the percentage, give the student one of the rewards.
 */

#region Here are the default variables with initial values that cannot be changed

double programming_basics = 0.0, physics = 0.0, chemistry = 0.0, total = 0.0, percentage = 0.0;
string first_name, last_name, selected_reward = "";

string first_reward = "10.000,00 EUR";  // all percentages above and equal to 60 
string second_reward = "5.000,00 EUR";  // all percentages above and equal to 48 and below 60 
string third_reward = "3.000,00 EUR";   // all percentages above and equal to 36 and below 48
string fourth_reward = "1.000,00 EUR";  // all percentages below 36 

#endregion


// Here we have basic logic to insert data
// ==================================================================
Console.Write("Student first name: ");
first_name = Console.ReadLine();
Console.Write("Student last name: ");
last_name = Console.ReadLine();

Console.Write("\nEnter the achieved points in \"Physics\" (0-100): ");
// Using If statement create input validation for "double" value type and save correct value in variable "physics"

Console.Write("\nEnter the achieved points in \"Chemistry\" (0-100): ");
// Using If statement create input validation for "double" value type and save correct value in variable "chemistry"

Console.Write("\nEnter the achieved points in \"Basics of Programming\" (0-100): ");
// Using If statement create input validation for "double" value type and save correct value in variable "programming_basics"

// ==================================================================
// NOTICE: If any of above validation fails, stop and exit the program.
// ==================================================================


// If above validations are success, continue running the code below
total = physics + chemistry + programming_basics;
percentage = total / 3.0;


// Insert your code logic below using combination of if, else if and else statements
// ==================================================================



#region This is here to help in imagining printing data to the console

Console.Write("\n\nStudent: {0} {1}\n", first_name, last_name);
Console.Write("Points in \"Physics\": {0}\nPoints in \"Chemistry\": {1}\nPoints from \"Fundamentals of Programming\": {2}\n", physics, chemistry, programming_basics);
Console.Write("Total points = {0}\nPercentage achieved = {1}\nThe student received an award = {2}\n", total, percentage, selected_reward);

#endregion

// This is only here to stop the program before exiting
Console.ReadKey();