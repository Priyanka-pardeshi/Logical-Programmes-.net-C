using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace LogicalProgrammes
{
    class StopWatch
    {
        public void StopWatch()
        {
            string time = DateTime.Now.ToString("h:mm:ss tt");
            Console.WriteLine("The current time is {0}", time);
        }
        
    }
}
