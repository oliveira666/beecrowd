using System;
using System.Globalization;

class URI {

    static void Main(string[] args) 
    { 
        double input = 0;
        do
        {
            input = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        } 
        while (input < 0 || input > 1000000.00);

        double[] dinheiro = {100.00,50.00,20.00, 10.00, 5.00, 2.00, 1.00, 0.50, 0.25, 0.10, 0.05, 0.01};
        double nota;
        foreach (double i in dinheiro)
        {
            nota = input / i;
            input %= i;

            if (i == 100.00)
                Console.WriteLine("NOTAS:");
            if (i == 1.00)
                Console.WriteLine("MOEDAS:");

            if (i == 0.01) // Tenta arrendodar valores pequenos 0.9999 para 1
                nota = Math.Round(nota);
            if (i > 1.00)
                Console.WriteLine((int)nota + " nota(s) de R$ " + i.ToString("F2", CultureInfo.InvariantCulture));
            else 
                Console.WriteLine((int)nota + " moeda(s) de R$ " + i.ToString("F2", CultureInfo.InvariantCulture));
        }
        Console.ReadLine();
    }
}
