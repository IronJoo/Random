using System;

namespace Testes
{
    class MainClass //{}
    {
        public static void Main(string[] args)
        {
            Console.Write("Insert a number: ");
            Console.Write(Factorial(int.Parse(Console.ReadLine())));

            Console.ReadLine();
        }
        static int Factorial(int num)
        {
            int result = num;
            for (int i = num; i > 1; i--)
            {
                result = result * (i - 1);
            }

            return result;
        }
    }
}