using System;

namespace Testes
{
    class MainClass //{}.
    {
        public static void Main(string[] args)
        {
            string secretWord = "giraffe";

            Console.WriteLine("Guess what word I'm thinking of!: ");
            string guess = Console.ReadLine();
            while (secretWord != guess)
            {
                Console.WriteLine("Incorrect! Try again: ");
                guess = Console.ReadLine();
            }

            Console.WriteLine("Congratulations, you got it!");



            Console.ReadLine();
        } 
    }
}