using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<float> numbers = new List<float>();
        float number = -1;
        float sum = 0;
        float higher = -1;
        while (number != 0)
        {
            Console.Write("Enter number: ");
            string nb = Console.ReadLine();
            float usernum = float.Parse(nb);
            number = usernum;
            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        foreach (float num in numbers)
        {
            sum += num;
        }
        foreach (float num in numbers)
        {
            Console.Write(num);
            if (num > higher)
            {
                higher = num;
            }
        }

        numbers.Sort();
        
        int len = numbers.Count;
        float average = sum/len;

        Console.Write("The sum is: ");
        Console.WriteLine(sum);
        Console.Write("The average is: ");
        Console.WriteLine(average);
        Console.Write("THe Largest number is: ");
        Console.WriteLine(higher);
    }
}
