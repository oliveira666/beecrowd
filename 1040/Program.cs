using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        string[] input = Console.ReadLine().Split(' ');
        double[] N = new double[input.Length];
        int[] peso = {2, 3, 4, 1};
        double media = 0.0;
        double notaFinal = 0.0;
        double mediaFinal = 0.0;

        for (int i = 0; i < input.Length; i++)
        {
            N[i] = double.Parse(input[i], CultureInfo.InvariantCulture);
        }
        // Media pondera = NotaA * PesoA + NotaB * PesoB [...] / PesoA + PesoB [...]
        
        media = ((N[0] * peso[0] +
                  N[1] * peso[1] +
                  N[2] * peso[2] +
                  N[3] * peso[3]) / 
                                  (peso[0] + peso[1] + peso[2] + peso[3]));
        // Tive que usar Math.Floor aqui pois o truncamento do C# está estranho entre o Visual Studio e o BeeCrowd
        // Sem Math.Floor o resultado de 4.85 truncado para uma casa decimal apenas por algum motivo está ficando 4.9 no beecrowd
        //O esperado de um truncamento é 4.85 -> 4.8 (Apenas remover a casa decimal, sem arredondar)
        media = Math.Floor(media * 10) / 10.0;


        Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));

        if (media >= 5.0 && media < 7.0) {
            Console.WriteLine("Aluno em exame.");
            notaFinal = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Nota do exame: " + notaFinal.ToString("F1", CultureInfo.InvariantCulture));
            mediaFinal = (media + notaFinal) / 2;
            if (mediaFinal >= 5.0)
                Console.WriteLine("Aluno aprovado.");
            else
                Console.WriteLine("Aluno reprovado.");
            Console.WriteLine("Media final: " + mediaFinal.ToString("F1", CultureInfo.InvariantCulture));
        }
        else if (media >= 7.0)
            Console.WriteLine("Aluno aprovado.");
        else if (media < 5.0)
            Console.WriteLine("Aluno reprovado.");
            Console.ReadLine();
    }
}