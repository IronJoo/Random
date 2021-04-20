using System;
using System.Collections.Generic;

namespace Testes
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Fibonacci Sequence\nHow many times do you want to run the sequence for?: ");
            int x = int.Parse(Console.ReadLine());
            int[] result = Fibonacci(x);
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }
        }
        static int[] Fibonacci(int nTimes)
        {
            int num1 = 0;
            int num2 = 1;
            List<int> result = new List<int>();
            for (int i = 0; i < nTimes; i++)
            {
                result.Add(num1 + num2);
                num1 = num2;
                num2 = result[i];
            }
            return result;

        }
    }
}
