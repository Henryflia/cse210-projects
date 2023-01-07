using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int number = int.Parse(grade);

        string letter = "A";

        if (number >= 90)
        {
            Console.WriteLine(letter);
        }
        else if (number >= 80 && number < 90)
        {
            letter = "B";
            Console.WriteLine(letter);
        }
        else if (number >= 70 && number < 80)
        {
            letter = "C";
            Console.WriteLine(letter);
        } 
        else if (number >= 60 && number < 70)
        {
            letter = "D";
            Console.WriteLine(letter);
        } 
        else 
        {
            letter = "F";
            Console.WriteLine(letter);
        } 
        if (number >=70)
        {
            Console.Write("Congratulation you passed the course");
        }
        else 
            Console.Write("Sorry, i know yoou can do it better the next time");

    }
}