using System;

namespace Testes
{
    class MainClass //{}
    {
        public static void Main(string[] args)
        {
            Console.Write("Insert a number: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Insert an operator: ");
            string op = Console.ReadLine();
            Console.Write("Insert another number: ");
            double num2 = double.Parse(Console.ReadLine());
            Console.Write($"You inserted the following calculation: {num1} {op} {num2} = ");
            if (op == "x" || op == "*")
            {
                Console.Write(num1 * num2);
            }
            else if (op == "+")
            {
                Console.Write(num1 + num2);
            }
            else if (op == "-")
            {
                Console.Write(num1 - num2);
            }
            else if (op == ":" || op == "/")
            {
                double result = num1 / num2;
                Console.Write(result);
            }
            else
            {
                Console.Write("Invalid operator.");
            }

            Console.ReadLine();
        } 
    }
}