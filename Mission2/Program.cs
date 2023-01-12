using System;

namespace Mission2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Set dice with launch arguments
            int numDice = 2;
            int numSides = 6;

            if (args.Length == 2)
            {
                numDice = int.Parse(args[0]);
                numSides = int.Parse(args[1]);
            }

            //Welcome message
            Console.WriteLine("Welcome to the dice throwing simulator!");
            Console.WriteLine("How many times would you like to throw the dice?");
            string? numberInput = Console.ReadLine();

            //Get number of throws
            int.TryParse(numberInput, out int timesToThrow);

            //Run simulation
            if (timesToThrow > 0)
            {
                var results = Simulator.HandleSimulation(timesToThrow, numDice, numSides);
                ResultsHandler.PrintResults(results, numDice, numSides);

            }
            else
            {
                Console.WriteLine("You must enter a number.");
            }
        }
    }
}
