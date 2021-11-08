using System;
using System.Collections.Generic;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input expression(example: \"2 + 3 * 5\"): ");
            var input = Console.ReadLine();
            SplitttingInput(input);
        }
        static void SplitttingInput(string expression)
        {
                var parts = expression.Split(' ');
                var variables = new List<double>();
                var operators = new List<char>();
            try { 
                for (int i = 0; i < parts.Length; i += 2)
                {
                    variables.Add(Convert.ToDouble(parts[i]));
                }
                for (int b = 1; b < parts.Length; b += 2)
                {
                    operators.Add(Convert.ToChar(parts[b]));
                }
            }
            catch
            {
                Console.WriteLine("Invalid input format");
            }
            finally
            {
                CountAndGetResult(variables, operators);
            }
         } 
        static void CountAndGetResult(List<double> variables, List<char> operators)
        {
            
            for (int y = 0; y < operators.Count + 1; y++) {
                for (int index = 0; index < operators.Count; index++)
                {
                    char j = operators[index];
                    if (Convert.ToInt32(j) == 42 || Convert.ToInt32(j) == 47)
                    {
                        if (Convert.ToInt32(j) == 42)
                        {
                            double a = variables[index] * variables[index + 1];
                            operators.RemoveAt(index);
                            variables.RemoveAt(index);
                            variables.RemoveAt(index);
                            variables.Insert(index, a);
                        }
                        else if (Convert.ToInt32(j) == 47)
                        {
                            double v = variables[index] / variables[index + 1];
                            operators.RemoveAt(index);
                            variables.RemoveAt(index);
                            variables.RemoveAt(index);
                            variables.Insert(index, v); 
                        }
                    }
                }
            }
            for (int g = 0; g < operators.Count + 1; g++)
            {
                for (int u = 0; u < operators.Count; u++)
                {
                    char o = operators[u];
                    if (Convert.ToInt32(o) == 43)
                    {
                        double l = variables[u] + variables[u + 1];

                        operators.RemoveAt(u);
                        variables.RemoveAt(u);
                        variables.RemoveAt(u);
                        variables.Insert(u, l);
                    }
                    else if (Convert.ToInt32(o) == 45)
                    {
                        double p = variables[u] - variables[u + 1];

                        operators.RemoveAt(u);
                        variables.RemoveAt(u);
                        variables.RemoveAt(u);
                        variables.Insert(u, p);
                    }
                }
            }
            Console.WriteLine("Result:");
            try
            {
                Console.WriteLine(variables[0]);
            }
            catch
            {
                Console.WriteLine("Not received");
            }
        }
    }
}
