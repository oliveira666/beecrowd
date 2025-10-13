using System;

class URI
{

    static void Main(string[] args)
    {

        int N = int.Parse(Console.ReadLine());

        int ano = N / 365;
        N %= 365;
        Console.WriteLine(ano + " ano(s)");
        int mes = N / 30;
        N %= 30;
        Console.WriteLine(mes + " mes(es)");
        int dia = N;
        Console.WriteLine(dia + "dia(s)");

        Console.ReadLine();

    }

}