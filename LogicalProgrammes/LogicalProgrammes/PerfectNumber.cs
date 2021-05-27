using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgrammes
{
    class PerfectNumber
    {
        public int Perfect(int value)
        {
            int sum = 0;
            for (int i = 1; i < value; i++)
            {
                if (value % i == 0) 
                sum = sum + i;
            }
            return sum; 
        }
    }
}
