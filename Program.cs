using System;

namespace Testes
{
    class MainClass //{}
    {
        public static void Main(string[] args)
        {
            Console.Write("From 1 to 10, insert a number to be guessed by your partner!: ");
            int secretNum = int.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Your number is secret! You may now pass your device to your partner.");
            Console.WriteLine("Press ENTER to begin.");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("You have 3 tries.\nFrom 1 to 10, guess what number I'm thinking of!: ");
            int guess = int.Parse(Console.ReadLine());
            int guessCount = 1;

            if (guess == secretNum)
            {
                Console.WriteLine("Congratulations, you got it on your first attempt!");
            }
            else
            {
                while (guessCount < 3 && guess != secretNum)
                {
                    Console.WriteLine("Incorrect! You have {0} attemp(s) left. Try again: ", (3 - guessCount));
                    guess = int.Parse(Console.ReadLine());
                    guessCount++;
                    if (guess == secretNum)
                    {
                        Console.WriteLine("Congratulations, you got it!");
                    }
                    else if (guessCount == 3 && guess != secretNum)
                    {
                        Console.WriteLine("You ran out of attempts.");
                    }
                }
            }
                
            Console.ReadLine();
        } 
    }
}