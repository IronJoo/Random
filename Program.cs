using System;

namespace Testes
{
    class MainClass //{}
    {
        public static void Main(string[] args)
        {
            Console.Write("Insert a number number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Insert another number: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"You inserted the numbers {num1} and {num2}.");
            Console.WriteLine("The highest of them is {0}.", Highest(num1, num2));
            

            Console.ReadLine();
        }
        static int Highest(int num1, int num2)
        {
            if (num1 > num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        } 
    }
}