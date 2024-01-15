using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Mission2_IS413
{
    // This is sceond class called Result
    internal class Result
    {
        // A method called DiceResult and n is the number of rolls has been passed from the first class
        public static int[] DiceResult(int n)


        {
            //  creating an instance of the Random class 
            Random random = new Random();

            // Initializes an integer array named array, The array has a length of 13 (0 -12)
            int[] array = new int[13];

            // Base on the number of n to run this for loop
            for (int i = 0; i < n; i++)
            {
                // Generate a random integer for Dice 1 (1-6)
                int dice1 = random.Next(1, 7);

                // Generate a random integer for Dice 2 (1-6)
                int dice2 = random.Next(1, 7);

                // Add the total numbers of 2 dices
                int total = dice1 + dice2;

                // Count the occurrences of each total and increment the corresponding array index
                array[total]++;

            }

            return array;


        }
    }
}