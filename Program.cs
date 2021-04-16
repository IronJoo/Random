using System;

namespace Testes
{
    class MainClass //{}
    {
        public static void Main(string[] args)
        {
            Console.Write("Fibonacci Sequence\nHow many times do you want to run the sequence for?: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine(Fibonacci(x));


        }
        int Fibonacci(int nTimes)
        {
            int num1 = 0;
            int num2 = 1;
            int result;
            for (int i = 1; i < nTimes; i++)
            {
                result = num1 + num2;
                num1 = num2;
                num2 = result;
            }
            return result;
        }
    }
}