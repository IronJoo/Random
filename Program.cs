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
            for (int i = 0; i < Fibonacci(nTimes).Count; i++)
            {
                Console.WriteLine(Fibonacci(nTimes)[i]);
            }
        }
        static List<int> Fibonacci(int nTimes)
        {
            List<int> result = new List<int>() { 0, 1 };
            for (int i = 2; i < nTimes; i++)
            {
                result.Add(result[i-1] + result[i-2]);
            }
            return result;

        }
    }
}
