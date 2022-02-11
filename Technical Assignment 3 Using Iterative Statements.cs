// Program developed by: Caroline Hansen
// Date: 02/10/2022
// This C# Console program demonstrates the use of iterative and conditional statements 
// to create a system for Border Provisioners showing the CAD to USD conversion output.

using System;

namespace Technical_Assignment_3_Using_Iterative_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Try-catch block to check user input for integer values.
            try
            {
                // Ask the user for input
                Console.WriteLine("Please enter a CAD to convert");

                // Gather and store user response in input
                string input = Console.ReadLine();
                // User reponse is parsed to int and stored in UserInputValue
                int UserInputValue = int.Parse(input);
                // Display the CAD Increment Value from UserInputValue that user inputted
                Console.WriteLine("CAD Increment Value: " + UserInputValue);
                

                // Establish an IF/ELSE statement to test if increment value from user input is between 5 and 25
                if (UserInputValue >= 5 && UserInputValue <= 25)
                {
                    // Establish string of text for CAD heading
                    string CADHeader = "CAD";
                    // Format CAD heading with padding to correctly display in table
                    string CADFormattedHeader = CADHeader.PadRight(1);
                    // Display formatted CAD heading to user
                    Console.Write(CADFormattedHeader);

                    // Establish string of text for USD heading
                    string USDHeader = "US$";
                    // Pad USD heading with padding to correctly display in table
                    string USDFormattedHeader = USDHeader.PadLeft(10);
                    // Display formatted USD heading to user
                    Console.WriteLine(USDFormattedHeader);


                    // This FOR loop computes and prints a table of values showing CAD to USD conversion
                    // It starts at 0 CAD and does not go beyond 200 CAD.
                    // The CAD value increments based on the UserInputValue.
                    for (int i = 0; i <= 200; i = i += UserInputValue)
                    {
                        // This data type stores the CAD to USD conversion rate multiplication function
                        double cadtousdconversion = i * 0.792367;

                        // Converts double data type to decimal data type because conversion rate is given as decimal
                        decimal formattedcadtousdconversion = Convert.ToDecimal(cadtousdconversion);
                        
                        // Displays CAD values starting at 0 and increasing by user input increment value. Formats alignment.
                        Console.Write("{0,-7:0}", i);

                        // Displays equivalent USD values in a currency format. Formats alignment.
                        Console.WriteLine("{0,7:0.00}", formattedcadtousdconversion);
                    }

                    // Displays message on how user should exit program
                    Console.WriteLine("Press any key to exit the program");
                    // Pauses the program and waits for user to press key
                    Console.ReadKey(true);
                }

                // If user input is not between 5 and 25, then display invalid message to the user
                else
                {
                    // Displays invalid message because user input is not between 5 and 25
                    Console.WriteLine("Invalid input.You must enter a value between 5 – 25.");
                    // Displays message on how user should exit program
                    Console.WriteLine("Press any key to exit the program and try again");
                    //Pauses the program and waits for user to press key
                    Console.ReadKey(true);
                } 

            } // End of try
            

            // Catch block executes when user inputs non-integer value
            catch
            {
                // Displays invalid message because user inputted non-integer value
                Console.WriteLine("Invalid input. You must enter an integer value!");
                // Displays message on how user should exit program
                Console.WriteLine("Press any key to exit and try again");
                // Pauses the program and waits for user to press key
                Console.ReadKey(true);
            }
        }
    }
}