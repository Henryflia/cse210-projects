using System;

class Circulo
{
    static void Main()
    {
        double radio;

        Console.WriteLine("Ingrese el radio del círculo:");
        string input = Console.ReadLine();

        if (double.TryParse(input, out radio))
        {
            double area = CalcularArea(radio);
            double perimetro = CalcularPerimetro(radio);

            Console.WriteLine("El área del círculo es: " + area);
            Console.WriteLine("El perímetro del círculo es: " + perimetro);
        }
        else
        {
            Console.WriteLine("Ingrese un valor válido para el radio.");
        }

        Console.ReadLine();
    }

    static double CalcularArea(double radio)
    {
        return Math.PI * Math.Pow(radio, 2);
    }

    static double CalcularPerimetro(double radio)
    {
        return 2 * Math.PI * radio;
    }
}
