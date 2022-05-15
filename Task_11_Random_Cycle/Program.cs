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
            int firstMultipleNumber = 3;
            int secondMultipleNumber = 5;

            for (int i = 0; i <= randomLimit; i++)
            {
                if (i % firstMultipleNumber == 0 || i % secondMultipleNumber == 0)
                    sumMultiples += i;
            }
            
            Console.WriteLine(sumMultiples);
        }
    }
}
