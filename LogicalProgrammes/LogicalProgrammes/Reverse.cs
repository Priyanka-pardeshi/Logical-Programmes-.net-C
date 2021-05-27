using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgrammes
{
    class Reverse
    {
        public void ReverseNumber(int Value) //127
        {
        
         int reverseNum =0, temp=0;
         Console.WriteLine("Input your number and press enter: ");
 
         while( Value != 0 )
         {
             temp = Value % 10;                  //127  //12  //1      
            reverseNum = reverseNum * 10+temp;    //
            Value = Value/10;                     //127  //12  //1   
         }

          Console.WriteLine("Reverse of input number is: "+reverseNum);
        }
    }
}
