using System;

class URI
{

    static void Main(string[] args)
    {

        int N = int.Parse(Console.ReadLine());

        int horas = N / 3600;
        N %= 3600;
        int minutos = N / 60;
        N %= 60;
        int segundos = N;

        Console.WriteLine(horas + ":" + minutos + ":" + segundos);
        Console.ReadLine();

    }

}