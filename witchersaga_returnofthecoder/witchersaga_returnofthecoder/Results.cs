using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace witchersaga_returnofthecoder
{
    public class Results : Engine
    {
        private int numYear, sumVillager;
        Engine engine = new Engine();
        public int[] GetVillageKilled(int ageofDeath, int yearofDeath)
        {
            int xOne = 1; int xTwo = 1;
            numYear = yearofDeath - ageofDeath;

            if (numYear > 2)
            {
                sumVillager = xOne + xTwo;
                int engineResult = engine.Calculated(xOne, xTwo, sumVillager, numYear);
                return new int[2] { numYear, engineResult };
            }
            else
            {
                return new int[2] { numYear, numYear };
            }
        }
        public double Average(List<int> valueOne)
        {
            return engine.AverageCalculated(valueOne);
        }
        public int CalculatedTwonumber(int valueOne, int valueTwo)
        {
            return engine.CalculatingTwonumber(valueOne, valueTwo);
        }
    }
}
