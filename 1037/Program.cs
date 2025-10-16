using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        string[] input = Console.ReadLine().Split(' ');
        int cod = int.Parse(input[0]);
        int qtd = int.Parse(input[1]);
        double preco = 0;
        double total = 0;

        switch (cod)
        {
            case 1:
                preco = 4.00; // Cachorro Quente
                break;
            case 2:
                preco = 4.50; //X Salada
                break;
            case 3:
                preco = 5.00; // X Bacon
                break;
            case 4:
                preco = 2.00; // Torrada Simples
                break;
            case 5:
                preco = 1.50; // Refrigerante
                break;
        }
        
        total = preco * qtd;
        Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        Console.ReadLine();

    }
}