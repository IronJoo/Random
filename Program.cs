using System;
using System.Collections.Generic;

namespace Testes
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("--Fibonacci Sequence--\nSelect the range of your sequence: ");
            int nTimes = int.Parse(Console.ReadLine());
            int[] result = Fibonacci(nTimes);
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }
        }
        static int[] Fibonacci(int nTimes)
        {
            int num1 = 0;
            int num2 = 1;
            int[] result = new int[nTimes];
            for (int i = 0; i < nTimes; i++)
            {
                result[i] = num1 + num2;
                num1 = num2;
                num2 = result[i];
            }
            return result;

        }
    }
}
