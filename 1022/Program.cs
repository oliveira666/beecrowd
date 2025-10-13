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

        int[,] num = new int[N, 4];
        char[] c = new char[N];
        int[] pos = new int[2];

        for (int i = 0; i < N; i++)
        {
            string[] input = Console.ReadLine().Split(' ');
            num[i, 0] = int.Parse(input[0]); // N1
            num[i, 1] = int.Parse(input[2]); // D1
            c[i] = char.Parse(input[3]);     // SINAL
            num[i, 2] = int.Parse(input[4]); // N2
            num[i, 3] = int.Parse(input[6]); // D2
        }

        for (int j = 0; j < N; j++)
        {
            switch (c[j])
            {
                case '/': // (N1*D2)/(N2*D1)
                    pos[0] = num[j, 0] * num[j, 3];
                    pos[1] = num[j, 2] * num[j, 1];

                    Console.Write(pos[0] + "/" + pos[1]);
                    MDC(ref pos[0], ref pos[1]);
                    Console.WriteLine(" = " + pos[0] + "/" + pos[1]);
                    break;
                case '*': // (N1*N2) / (D1*D2)
                    pos[0] = num[j, 0] * num[j, 2];
                    pos[1] = num[j, 1] * num[j, 3];

                    Console.Write(pos[0] + "/" + pos[1]);
                    MDC(ref pos[0], ref pos[1]);
                    Console.WriteLine(" = " + pos[0] + "/" + pos[1]);
                    break;
                case '+': // (N1*D2 + N2*D1) / (D1*D2)
                    pos[0] = (num[j, 0] * num[j, 3]) + (num[j, 2] * num[j, 1]);
                    pos[1] = num[j, 1] * num[j, 3];

                    Console.Write(pos[0] + "/" + pos[1]);
                    MDC(ref pos[0], ref pos[1]);
                    Console.WriteLine(" = " + pos[0] + "/" + pos[1]);
                    break;
                case '-': // (N1*D2 - N2*D1) / (D1*D2)
                    pos[0] = num[j, 0] * num[j, 3] - num[j, 2] * num[j, 1];
                    pos[1] = num[j, 1] * num[j, 3];

                    Console.Write(pos[0] + "/" + pos[1]);
                    MDC(ref pos[0], ref pos[1]);
                    Console.WriteLine(" = " + pos[0] + "/" + pos[1]);
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

        // Mantém o sinal no numerador
        if (denominador < 0)
        {
            numerador *= -1;
            denominador *= -1;
        }
    }

}
