using System;

class URI
{

    static void Main(string[] args)
    {

        string[] input = Console.ReadLine().Split(' ');

        int a = int.Parse(input[0]);
        int b = int.Parse(input[1]);
        int c = int.Parse(input[2]);
        
        int maior = a;
        if (b > maior) maior = b;
        if (c > maior) maior = c;
        Console.WriteLine(maior + " eh o maior");

        Console.ReadLine();
    }

}