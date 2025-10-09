using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        string nome = Console.ReadLine();
        double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double vendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double comissao = 0.15; // 15%

        double total = salario + (vendas * comissao);

       
        Console.WriteLine("TOTAL = R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        Console.ReadLine();

    }

}