using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        int rendimento = 12;
        int horas = int.Parse(Console.ReadLine());
        int velMedia = int.Parse(Console.ReadLine());

        double totalKM = horas * velMedia;
        double qtdLitros = totalKM / rendimento;

        Console.WriteLine(qtdLitros.ToString("F3", CultureInfo.InvariantCulture));
        Console.ReadLine();
    }

}