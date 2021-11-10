using System;
using System.Collections.Generic;

namespace Calc
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            Console.Write("Input expression(example: \"2 + 3 * 5\"): ");
            var input = Console.ReadLine();
            Calculator.SplittingInput(input);
            
        }
        
        public static void GetResult(List<double> variables)
        {
            Console.WriteLine("Result:");
            Console.WriteLine(variables[0]);
        }
    }
    
}
