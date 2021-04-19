using System;

namespace Testes
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double num1;
            double num2;
            Console.Write("Insert a number: ");
            num1 = GetValidNumber();
            Console.Write("Insert an operator: ");
            string op = GetValidOperator();
            Console.Write("Insert another number: ");
            num2 = GetValidNumber();
            Console.Write($"Your calculation is: {num1} {op} {num2} = {GetCalculation(num1, op, num2)}");
            Console.ReadLine();
        }
        static double GetValidNumber()
        {
            double x;
            while (!double.TryParse(Console.ReadLine(), out x))
            {
                Console.Write("Insert a valid number: ");
            }

            return x;
        }
        static string GetValidOperator()
        {
            string x = Console.ReadLine();

            while (x != "x" && x != "*" && x != "+" && x != "-" && x != ":" && x != "/")
            {
                Console.Write("Insert a valid operator: ");
                x = Console.ReadLine();
            }
            return x;
        }
        static double GetCalculation(double num1, string op, double num2)
        {
            switch (op)
            {
                case "x":
                case "*":
                    return num1 * num2;
                case "+":
                    return num1 + num2;
                case "-":
                    return num1 - num2;
                case ":":
                case "/":
                    return num1 / num2;
                default:
                    return 0; //unreachable
            }

        }
    }
}
