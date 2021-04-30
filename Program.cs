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
            List<int> result = Fibonacci(nTimes);
            for (int i = 0; i < result.Count; i++)
            {
                Console.WriteLine(result[i]);
            }
        }
        static List<int> Fibonacci(int nTimes)
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
