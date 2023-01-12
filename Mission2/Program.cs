using System;

namespace Mission2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Set dice with launch arguments
            int? numDice = null;
            int? numSides = null;

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
                //Too complex. Refactor.
                if (numDice != null && numSides != null)
                {
                    var results = Simulator.HandleSimulation(timesToThrow, (int)numDice, (int)numSides);
                    ResultsHandler.PrintResults(results, (int)numDice, (int)numSides);
                }
                else
                {
                    var results = Simulator.HandleSimulation(timesToThrow);
                    ResultsHandler.PrintResults(results);
                }
            }
            else
            {
                Console.WriteLine("You must enter a number.");
            }
        }
    }
}
