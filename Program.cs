using System;



    class Program
    {
        static void Main(string[] args)
        {
            double result;
            Console.Write("Input expression(example: \"2 + 3 * 5\"): ");
            string expression = Console.ReadLine();
            Calculator Expression = new Calculator();
            try
            {
                result = Expression.Evaluate(expression);
                if ((result != double.PositiveInfinity) && (result != double.NegativeInfinity))
                {
                Console.WriteLine($"Result:{result}");
                }
                else
                {
                    Console.WriteLine("Error:division by zero");
                }
            }
           catch(System.FormatException)
            {
                Console.WriteLine("Error:invalid input format");
            }
        }
    }

