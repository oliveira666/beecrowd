using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {
        double pi = 3.14159;

        string[] input = Console.ReadLine().Split(' ');

        double A = double.Parse(input[0], CultureInfo.InvariantCulture);
        double B = double.Parse(input[1], CultureInfo.InvariantCulture);
        double C = double.Parse(input[2], CultureInfo.InvariantCulture);

        double areaTri = (A * C) / 2;
        double areaC = pi * Math.Pow(C, 2);
        double areaTra = (A + B) * C / 2;
        double areaQ = Math.Pow(B, 2);
        double areaR = A * B;

        Console.WriteLine("TRIANGULO: " + areaTri.ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine("CIRCULO: " + areaC.ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine("TRAPEZIO: " + areaTra.ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine("QUADRADO: " + areaQ.ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine("RETANGULO: " + areaR.ToString("F3", CultureInfo.InvariantCulture));
        Console.ReadLine();

    }

}