using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        double A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double pesoA = 3.5;
        double pesoB = 7.5;

        // Media ponderada
        // Nota * Peso / Peso
        double media = (A * pesoA + B * pesoB) / (pesoA + pesoB);

        Console.WriteLine("MEDIA = " + media.ToString("F5", CultureInfo.InvariantCulture));
        Console.ReadLine();

    }

}