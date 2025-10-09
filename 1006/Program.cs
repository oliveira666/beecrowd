using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        double A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double pesoA = 2.0;
        double pesoB = 3.0;
        double pesoC = 5.0;

        // Media ponderada
        // Nota * Peso / Peso
        double media = (A * pesoA + B * pesoB + C * pesoC) / (pesoA + pesoB + pesoC);

        Console.WriteLine("MEDIA = " + media.ToString("F1", CultureInfo.InvariantCulture));
        Console.ReadLine();

    }

}