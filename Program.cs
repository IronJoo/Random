using System;

namespace Testes
{
    class MainClass //{}
    {
        public static void Main(string[] args)
        {
            Console.Write(PowerOf(2, 5));
                
            Console.ReadLine();
        }

        static decimal PowerOf(decimal num1, decimal num2)
        {
            int i;
            decimal result = 1;

            for (i = 1; i <= num2; i++)
            {
                result = result * num1;
            }
            return result;
        }
    }
}