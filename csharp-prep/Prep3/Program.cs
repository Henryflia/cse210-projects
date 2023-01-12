using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);

        Console.Write("What is your guess? ");
        string numbergs = Console.ReadLine();
        int guess = int.Parse(numbergs);
        if (guess < number)
        {
            Console.WriteLine("Higher");
        }
        else if (guess > number)
        {
            Console.WriteLine("Lower");
        }
        do
        {
            Console.Write("What is your guess? ");
            numbergs = Console.ReadLine();
            guess = int.Parse(numbergs);
            if (guess < number)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > number)
            {
                Console.WriteLine("Lower");
            }
        } while (number != guess);
        if (number == guess)
            Console.Write("You guessed it");
            
        

    }
}