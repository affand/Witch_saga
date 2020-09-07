using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace witchersaga_returnofthecoder
{
    public class Engine 
    {
        public int Calculated(int xOne, int xTwo, int sumVillager,int numYear)
        {
            int i = 2;
            int xThree;
            while (i < numYear)
	        {
                xThree = xOne + xTwo;
                sumVillager += xThree;
                xOne = xTwo;
                xTwo = xThree;
                i += 1;
            }
            return sumVillager;
        }
        public double AverageCalculated(List<int> listSumVillage)
        {
            double jumlah = 0;
            double total = listSumVillage.Count;
            double hasil;

            for(int k = 0; k < total; k++)
            {
                jumlah += listSumVillage[k];
            }
            hasil = jumlah / total;
            return hasil;
        }
        public int CalculatingTwonumber(int AOD, int YOD)
        {
            if(YOD - AOD < 0)
            {
                return -1;
            }
            return 0;
        }
    }
}
