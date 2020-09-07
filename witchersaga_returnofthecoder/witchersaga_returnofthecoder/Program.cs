using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace witchersaga_returnofthecoder
{
    public class Program : Results
    {
        static void Main(string[] args)
        {
            Results res = new Results();

            List<int> AOD = new List<int>();
            List<int> YOD = new List<int>();

            List<int> ListNumYear = new List<int>();
            List<int> ListSumVillage = new List<int>();
            
            int countPeople;
            double Avg;

            int[] Result;

            int i = 0;

            string avgStr = "(";
            
            Console.Write("Input Count of Villain : ");
            countPeople = int.Parse(Console.ReadLine().Trim());

            while (i < countPeople)
            {
                Console.WriteLine("Person " + (i + 1));
                Console.Write("Age of Death : ");

                AOD.Add(int.Parse(Console.ReadLine().Trim()));
                
                Console.Write("Year of Death : ");
                
                YOD.Add(int.Parse(Console.ReadLine().Trim()));

                if (res.CalculatedTwonumber(AOD[i], YOD[i]) == -1)
                {
                    Console.WriteLine("For person " + (i+1) + " -1 , Please try with correct number");
                    Console.ReadLine();
                    System.Environment.Exit(0);
                }
                Console.WriteLine();
                i += 1;
            }

            for (int j = 0; j < AOD.Count; j++)
            {
                Result = res.GetVillageKilled(AOD[j], YOD[j]);
                ListNumYear.Add(Result[0]);
                ListSumVillage.Add(Result[1]);

                if (j == AOD.Count - 1)
                {
                    avgStr += Result[1].ToString();
                }
                else
                {
                    avgStr += Result[1].ToString() + " + ";
                }
                Array.Clear(Result, 0, Result.Length);
            }

            avgStr += ")";
            avgStr += " / " + ListSumVillage.Count;

            for (int k = 0; k < ListNumYear.Count; k++)
            {
                Console.WriteLine("Person "+(k+1)+" born on year "+YOD[k]+" - "+AOD[k]+" number of people killed on year "+ListNumYear[k]+" is "+ListSumVillage[k]+".");
            }

            Avg = res.Average(ListSumVillage);
            Console.WriteLine("So the average is " + avgStr + " : "+Avg);
            Console.ReadLine();
        }
    }
}

