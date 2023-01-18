using System;

namespace Practice1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Decalre ramdom variable and create an array that holds 11 elements (2-12)
            Random r = new Random();
            int[] storage = new int[11];

            //Start Game and prompting the user for the Number of rolls
            Console.WriteLine("Welcome to the dice throwing simulator! ");
            Console.WriteLine("How many dice rolls would you like to simulate ?");
            double numRolls = Convert.ToInt32(Console.ReadLine());

            //Loop and roll the dice
            for (int i = 0; i < numRolls;  i++)
            {
                int firstDice = r.Next(1, 7); //Rolling Dice 1
                int SecondDice = r.Next(1, 7); //Rolling Dice 2
                int rollCombination = firstDice + SecondDice; // Adding Dice1 result to Dice2 result to get the combination of both 
                storage[rollCombination - 2]++; // -2 since the min conbination is 2 and want to start at Index 0.
            }

            Console.Write("DICE ROLLING SIMULATION RESULTS" + "\n");
            Console.Write("Each \"*\" represents 1% of the total number of rolls." + "\n");
            Console.Write("Total number of rolls = " + numRolls + "." + "\n");

            for (int i = 0; i < storage.Length; i++) // from Index 0 to 10
            {
                //print results 2-12:
                Console.Write((i + 2) + ": ");
                //Calculate percentage and store it in variable
                int percent = (int)((storage[i] / numRolls) * 100);
                //print starts based on percent result
                for (int j = 0; j < percent; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            //End simulation
            Console.WriteLine("\n" + "Thank you for using the dice throwing simulator. Goodbye!");
        }
    }
}
