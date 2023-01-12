using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2
{
    public static class Simulator
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="timesToThrow"></param>
        /// <param name="numDice"></param>
        /// <param name="sidesOnDice"></param>
        /// <returns></returns>
        public static List<int> HandleSimulation(int timesToThrow, int numDice = 2, int sidesOnDice = 6)
        {
            Random random= new Random();
            List<int> resultList = new();

            //Number of rolls
            for (int i = 0; i < timesToThrow; i++)
            {
                //Sides on dice
                int rollTotal = 0;
                for (int t = 0; t < numDice; t++)
                {
                    rollTotal += random.Next(1, sidesOnDice + 1);
                }

                resultList.Add(rollTotal);
            }

            return resultList;
        }
    }
}