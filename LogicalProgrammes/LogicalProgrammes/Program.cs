using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace LogicalProgrammes
{
    class Program
    {
        static void Main(string[] args)
        {
            //febo
            Console.WriteLine("Welcome to Logical Programs of C#");
            Console.WriteLine("Enter ypur choice :");
            Console.WriteLine("1:febo");
            Console.WriteLine("2:perfect");
            Console.WriteLine("3:Prime");
            Console.WriteLine("4:Reverse");
            Console.WriteLine("5: Stopwatch");
       
            int choice =Convert.ToInt32(Console.ReadLine());

            switch (choice)
            { 
                case 1:
                    Fabonacci objFebonacci = new Fabonacci();
                    Console.WriteLine("Enter Numer to see febonacci series:");
                    int inputFebonacii = Convert.ToInt32(Console.ReadLine()); 
                    objFebonacci.Febonaccii(inputFebonacii);
                    break;
                case 2:

                    //Perfect
                    PerfectNumber objPerfect = new PerfectNumber();
                    Console.WriteLine("Enter number to check is perfect or not:");
                    int inputPerfect = Convert.ToInt32(Console.ReadLine());
                    int resultPerfect=objPerfect.Perfect(inputPerfect);
                    if (inputPerfect == resultPerfect)
                    {
                        Console.WriteLine("Is Perfect number");
                    }
                    else 
                    {
                        Console.WriteLine("not perfect number");
                    }
                    break;
                case 3:
                    //Prime
                    Prime objPrime = new Prime();
                    Console.WriteLine("enter number to check its prime or not : ");
                    int inputPrime = Convert.ToInt32(Console.ReadLine());
                    objPrime.PrimeNumber(inputPrime);
                    break;
                case 4:
                    //reverses
                    Reverse objReverse = new Reverse();
                    Console.WriteLine("Enter number to check revser");
                    int inputRevers = Convert.ToInt32(Console.ReadLine());
                    objReverse.ReverseNumber(inputRevers);
                    break;
                case 5:
                    StopWatch objStopWatch = new StopWatch();
                    objStopWatch.StopWatch();
                    break;

                default :
                    Console.WriteLine("Oops try again..");
                    choice = Convert.ToInt32(Console.ReadLine());
                    break;
            }
            Console.ReadKey(); 
           
        }
    }
}
