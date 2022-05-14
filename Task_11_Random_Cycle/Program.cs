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
            Random random = new Random();
            int randomLimit = random.Next(0, 100);
            int sum = 0;

            for (int termsNumber = 0; termsNumber < randomLimit; termsNumber++)
            {
                if (termsNumber % 3 == 0 || termsNumber % 5 == 0)
                    sum += termsNumber;
            }
            
            Console.WriteLine(sum);
        }
    }
}
