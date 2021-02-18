using System;

namespace Testes
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Are you male? (Insert 'true' or 'false'): ");
            bool isMale = Convert.ToBoolean(Console.ReadLine());
            Console.Write("Are you tall? (Insert 'true' of 'false'): ");
            bool isTall = Convert.ToBoolean(Console.ReadLine());

            if (isMale && isTall)
            {
                Console.WriteLine("You are male and you are tall!");
            }
            else
            {
                if (!isMale && isTall)
                {
                    Console.WriteLine("You are not male and you are tall!");
                }
                else
                {
                    if (!isTall && isMale)
                    {
                        Console.WriteLine("You are male and you are not tall!");
                    }
                    else
                    {
                        Console.WriteLine("You are not male and you are not tall!");
                    }
                }
            }
            Console.ReadLine();
        }
    }
}