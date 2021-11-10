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
            Calculator.Processing(input);
            
        }
        
        public static void GetResult(List<double> variables, List<char>operators)
        {
            Console.WriteLine("Result:");
            Console.WriteLine(Calculator.Count(variables, operators));
        }
    }
    
}
