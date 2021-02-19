using System;

namespace Testes
{
    class MainClass //{}
    {
        public static void Main(string[] args)
        {
            Console.Write("Are you male?: ");
            string temp = Console.ReadLine();
            bool isMale = true;
            bool isTall = true;
            if (temp.ToLower().Equals("yes"))
            {
                isMale = true;
            }
            else if (temp.ToLower().Equals("no"))
            {
                isMale = false;
            }
            Console.Write("Are you tall?: ");
            string temp2 = Console.ReadLine();
            if (temp2.ToLower().Equals("yes"))
            {
                isTall = true;
            }
            else if (temp2.ToLower().Equals("no"))
            {
                isTall = false;
            }

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