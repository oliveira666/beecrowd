using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        string[] input = Console.ReadLine().Split(' ');

        double a = double.Parse(input[0], CultureInfo.InvariantCulture);
        double b = double.Parse(input[1], CultureInfo.InvariantCulture);
        double c = double.Parse(input[2], CultureInfo.InvariantCulture);

        double delta = Math.Pow(b, 2) - (4 * a * c);

        double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
        double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

        if (delta < 0 || a <= 0 )
        {
            Console.WriteLine("Impossivel calcular");
        }
        else
        {
            Console.WriteLine("R1 = " + x1.ToString("F5", CultureInfo.InvariantCulture));
            Console.WriteLine("R2 = " + x2.ToString("F5", CultureInfo.InvariantCulture));
        }
        Console.ReadLine();
    }

}