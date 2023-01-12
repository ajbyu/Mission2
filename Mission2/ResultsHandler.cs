using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2
{
    public static class ResultsHandler
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="rolls"></param>
        public static void PrintResults(List<int> rolls, int numDice = 2, int sidesOnDice = 6)
        {
            int totalRolls = rolls.Count;
            int maxNum = numDice * sidesOnDice;

            Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each '*' represents 1 % of the total number of rolls.");
            Console.WriteLine($"Total number of rolls = {totalRolls}.\n");

            //Unique values
            List<int> uniqueValues = rolls
                .Select(r => r)
                .Distinct()
                .OrderBy(r => r)
                .ToList();

            //Get percent and print
            for (int i = numDice; i <= maxNum; i++)
            {
                //Get percentage of total
                int count = rolls
                    .Where(r => r == i)
                    .Count();

                float numStars = ((float)count / (float)totalRolls) * 100;

                string stars = "";

                for (int j = 0; j < numStars; j++)
                {
                    stars += "*";
                }

                Console.WriteLine($"{i}. {stars}");
            }
        }
    }
}
