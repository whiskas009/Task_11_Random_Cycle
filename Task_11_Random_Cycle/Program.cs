using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_11_Random_Cycle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minRandomValue = 0;
            int maxRandomValue = 100;
            Random random = new Random();
            int randomLimit = random.Next(minRandomValue, maxRandomValue);
            
            int sumMultiples = 0;
            int multipleNumber_1 = 3;
            int multipleNumber_2 = 5;

            for (int termsNumber = 0; termsNumber < randomLimit; termsNumber++)
            {
                if (termsNumber % multipleNumber_1 == 0 || termsNumber % multipleNumber_2 == 0)
                    sumMultiples += termsNumber;
            }
            
            Console.WriteLine(sumMultiples);
        }
    }
}
