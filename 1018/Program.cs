using System;

class URI
{

    static void Main(string[] args)
    {
        int valor = int.Parse(Console.ReadLine());
        Console.WriteLine(valor);
        int[] cedulas = { 100, 50, 20, 10, 5, 2, 1 };
        int nota;

        foreach (int i in cedulas) {
            nota = valor / i;
            valor %= i;
            Console.WriteLine(nota + " nota(s) de R$ " + i + ",00");
        }
        Console.ReadLine();

    }

}