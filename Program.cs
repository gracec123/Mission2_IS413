using Mission2_IS413;
using System;
using System.Xml.Linq;


// First Class called Program to allow user input number of times of rolling two 6-sided dice.
internal class Program
{
    private static void Main()
    {
        // Set variable rolls is integer
        int rolls = 0;

        // Show welcome message
        System.Console.WriteLine("Welcome to the dice throwing simulator!" + "\n");

        // Allows User to Input Number of Rolls
        System.Console.WriteLine("How many dice rolls would you like to simulate? ");
        rolls = int.Parse(System.Console.ReadLine());

        // Program Passes Number of Rolls to Result Class
        int[] resultArray = Result.DiceResult(rolls);

        // This is the decription of the rolling dices game and result
        System.Console.WriteLine("\n" + "DICE ROLLING SIMULATION RESULTS");
        System.Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        System.Console.WriteLine("Total number of rolls = " + rolls + "." + "\n");

        // Loop through possible sums of two dice (2 to 12)
        for (int i = 2; i <= 12; i++)
        {
            // Calculate the percentage of occurrences for the current sum
            int percentage = (resultArray[i] * 100) / rolls;

            // Display the histogram bar for the current sum
            System.Console.Write(i + ": " + new string('*', (int)percentage) + "\n");
        }

        // Closing Message 
        System.Console.WriteLine("\n" + "Thank you for using the dice throwing simulator. Goodbye!");

    }





}