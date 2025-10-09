using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        int ID = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        int horas = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        float valorHora = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        float salario = horas * valorHora;

        Console.WriteLine("NUMBER = " +  ID);
        Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));
        Console.ReadLine();
    
    }

}