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
            Console.Write("Insert one more number: ");
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine($"You inserted the numbers {num1}, {num2} and {num3}.");
            Console.WriteLine("The highest of them is {0}.", Highest(num1, num2, num3));
            

            Console.ReadLine();
        }
        private static int Highest(int num1, int num2, int num3)
        {
            if (num1 >= num2 && num1 >= num3)
            {
                return num1;
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                return num2;
            }
            else
            {
                return num3;
            }
        } 
    }
}