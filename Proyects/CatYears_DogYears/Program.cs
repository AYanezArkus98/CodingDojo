using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatYears_DogYears
{
    internal class Program
    {

        public static int[] HumanCatDogYears(int humanYears)
        {
            int catYears = 0;
            int dogYears = 0;

            // Cálculo para los gatos
            if (humanYears == 1)
            {
                catYears = 15;
                dogYears = 15;
            }
            else if (humanYears == 2)
            {
                catYears = 15 + 9;
                dogYears = 15 + 9;
            }
            else if (humanYears >= 3)
            {
                catYears = 15 + 9 + (humanYears - 2) * 4;
                dogYears = 15 + 9 + (humanYears - 2) * 5;
            }

            return new int[] { humanYears, catYears, dogYears };
        }

        static void Main(string[] args)
        {
            int humanYears = 10;

            int[] result = HumanCatDogYears(humanYears);

            Console.WriteLine($"Human years: {result[0]}, Cat years: {result[1]}, Dog years: {result[2]}");

            Console.ReadKey();
        }
    }
}
