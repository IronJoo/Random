using System;

namespace Testes
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("--Fibonacci Sequence--\nSelect the range of your sequence: ");
            int nTimes = int.Parse(Console.ReadLine());
            
            int num1 = 0;
            int num2 = 1;
            int result;

            for (int i = 0; i < nTimes; i++)
            {
                result = num1 + num2;
                num1 = num2;
                num2 = result;
                Console.WriteLine(result);
            }
        }
    }
}
