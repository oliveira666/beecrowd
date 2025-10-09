using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        int distancia = int.Parse(Console.ReadLine());
        double combustivel = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double consumo = distancia / combustivel;

        Console.WriteLine(consumo.ToString("F3", CultureInfo.InvariantCulture) + " km/l");
        Console.ReadLine();

    }

}