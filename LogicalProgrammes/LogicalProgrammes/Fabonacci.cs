using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgrammes
{
    class Fabonacci
    {
        public void Febonaccii(int Number)
        {
            int a = 0, b = 1;
            int c=0;

            Console.Write(" Febonacci Series is====>"+a);
            for (int i = 2; i <= Number; i++)
            {
                a = b;
                b = c;
                c = a + b;
                Console.Write(" "+c);
            }
        }
    }
}
