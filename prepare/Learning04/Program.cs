using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment simple = new MathAssignment("Roberto Rodriguez","Fractions", "7.3", "8-19");
        Console.WriteLine(simple.GetSummary());
        Console.WriteLine(simple.GetHomeworkList());

        WritingAssignment homework2 = new WritingAssignment("Mary Waters","European History","The Causes of World War II");
        Console.WriteLine(homework2.GetSummary());
        Console.WriteLine(homework2.GetWritingInformation());
    }
}