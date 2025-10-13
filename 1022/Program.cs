using System;

class URI
{
    static void Main(string[] args)
    {
        int N;
        int mdc;
        do
        {
            N = int.Parse(Console.ReadLine());
        }
        while (N < 1 || N > Math.Pow(10, 4));

        int[,] numerador = new int[N, 4];
        int[,] denominador = new int [N, 4];
        char[] c = new char[N];
        int[] pos = new int[2];

        // Armazena todas variáveis nesse loop
        for (int i = 0; i < N; i++)
        {
            string[] input = Console.ReadLine().Split(' ');
            numerador[i, 0] = int.Parse(input[0]); // N1
            denominador[i, 0] = int.Parse(input[2]); // D1
            c[i] = char.Parse(input[3]);     // SINAL
            numerador[i, 1] = int.Parse(input[4]); // N2
            denominador[i, 1] = int.Parse(input[6]); // D2
        }
        // Cálcula e mostra na tela
        for (int j = 0; j < N; j++)
        {
            switch (c[j])
            {
                case '/': // (N1*D2)/(N2*D1)
                    numerador[0,3] = numerador[j, 0] * denominador[j, 1];
                    denominador[0,3] = numerador[j, 1] * denominador[j, 0];

                    Console.Write(numerador[0,3] + "/" + denominador[0,3]);
                    MDC(ref numerador[0,3], ref denominador[0,3]);
                    Console.WriteLine(" = " + numerador[0,3] + "/" + denominador[0,3]);
                    break;
                case '*': // (N1*N2) / (D1*D2)
                    numerador[0,3] = numerador[j, 0] * numerador[j, 1];
                    denominador[0,3] = denominador[j, 0] * denominador[j, 1];

                    Console.Write(numerador[0,3] + "/" + denominador[0,3]);
                    MDC(ref numerador[0,3], ref denominador[0,3]);
                    Console.WriteLine(" = " + numerador[0,3] + "/" + denominador[0,3]);
                    break;
                case '+': // (N1*D2 + N2*D1) / (D1*D2)
                    numerador[0,3] = (numerador[j, 0] * denominador[j, 1]) + (numerador[j, 1] * denominador[j, 0]);
                    denominador[0,3] = denominador[j, 0] * denominador[j, 1];

                    Console.Write(numerador[0,3] + "/" + denominador[0,3]);
                    MDC(ref numerador[0,3], ref denominador[0,3]);
                    Console.WriteLine(" = " + numerador[0,3] + "/" + denominador[0,3]);
                    break;
                case '-': // (N1*D2 - N2*D1) / (D1*D2)
                    numerador[0,3] = numerador[j, 0] * denominador[j, 1] - numerador[j, 1] * denominador[j, 0];
                    denominador[0,3] = denominador[j, 0] * denominador[j, 1];

                    Console.Write(numerador[0,3] + "/" + denominador[0,3]);
                    MDC(ref numerador[0,3], ref denominador[0,3]);
                    Console.WriteLine(" = " + numerador[0,3] + "/" + denominador[0,3]);
                    break;
            }
        }
        Console.ReadLine();
    }
    /* Essa função eu confiei ao Chat GPT pois no momento em que estou fazendo esse exercício
     * não possuo o conhecimento necessário de matemática para simplificar ou melhorar esse código */
    static void MDC(ref int numerador, ref int denominador)
    {
        // Calcula o MDC (método de Euclides)
        int a = Math.Abs(numerador);
        int b = Math.Abs(denominador);
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }

        // Divide ambos pelo MDC encontrado
        int mdc = a;
        numerador /= mdc;
        denominador /= mdc;

        // Mantém o sinal no numeradorerador
        if (denominador < 0)
        {
            numerador *= -1;
            denominador *= -1;
        }
    }

}