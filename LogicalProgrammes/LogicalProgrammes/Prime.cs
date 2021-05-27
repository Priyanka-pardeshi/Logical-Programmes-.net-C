using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgrammes
{
    class Prime
    {
        public void PrimeNumber(int value)
        {
            int reminder = 0; 
            for (int i = 2; i <= value/2; i++)
            {
                if (value % i == 0)
                {
                    reminder = 0;
                }
                else
                {
                    reminder=1;
                }
            }
            if (reminder == 0)
            {
                Console.WriteLine("not Prime");
            }
            else
            {
                Console.WriteLine("Prime"); 
            }
        }
    }
}
