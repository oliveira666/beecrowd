using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {
        // qtd de linhas de input
        int n = 2;
        double total = 0;
        int[] cod = new int[n];
        int[] qtd = new int[n];
        double[] preco = new double[n];

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split(' ');
            
            cod[i] = int.Parse(input[0]);
            qtd[i] = int.Parse(input[1]);
            preco[i] = double.Parse(input[2], CultureInfo.InvariantCulture);

            total += qtd[i] * preco[i];
        }
        Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        Console.ReadLine();
    }
}   