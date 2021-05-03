using System;

namespace Testes
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("--Fibonacci Sequence--\nSelect the range of your sequence: ");
            int nTimes = int.Parse(Console.ReadLine());
            for (int i = 0; i < Fibonacci(nTimes).Length; i++)
            {
                Console.WriteLine(Fibonacci(nTimes)[i]);
            }
        }
        static int[] Fibonacci(int nTimes)
        {
            int[] result = new int[nTimes];
            result[0] = 0;
            result[1] = 1;
            for (int i = 2; i < nTimes; i++)
            {
                result[i] = result[i-1] + result[i-2];
            }
            return result;
        }
    }
}
