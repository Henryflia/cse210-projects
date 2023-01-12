using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayMessage();
        string user = PromptUserName();
        int fNumber = PromptUserNumber();
        int squareNum = SquareNumber(fNumber);
        DisplayResult(user,squareNum);

        static void DisplayMessage()
        {
            Console.WriteLine("Welcome to the Program!");
        }
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            return userName;
        }
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string favorite = Console.ReadLine();
            int favoriteNumber = int.Parse(favorite);
            return favoriteNumber;
        }
        static int SquareNumber(int square)
        {
            int squared = square * square;
            return squared;
        }
        static void DisplayResult(string user, int squareNum)
        {
            Console.Write($"{user}, the square of you number is {squareNum}");
        }

    }
}