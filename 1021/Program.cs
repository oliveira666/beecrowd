using System; 

class URI {

    static void Main(string[] args) 
    { 
        double input = 0;
        do
        {
            input = double.Parse(Console.ReadLine());
        } 
        while (input < 0 || input > 1000000.00);

        double[] dinheiro = {100.00,50.00,20.00, 10.00, 5.00, 2.00, 1.00, 0.50, 0.25, 0.10, 0.05, 0.01};
        double qtd = 0;
        for (int i = 0; i < dinheiro.Length; i++)
        {
            string tipoMoeda = "";
            
            if (i == 0)
            {
                tipoMoeda = "NOTAS:";
                Console.WriteLine(tipoMoeda);
            }
            if (i <= 5)
            {
                tipoMoeda = "NOTA";
                
            }
            if (i == 6)
            {
                tipoMoeda = "MOEDAS:";
                Console.WriteLine(tipoMoeda);
            }
            if (i > 5)
            {
                tipoMoeda = "MOEDA";
                
            }

            qtd = input / dinheiro[i];
            input = Math.Round(input % dinheiro[i], 2);

            Console.WriteLine("{0} {1}(s) de R$ {2}", (int)qtd, tipoMoeda.ToLower(), dinheiro[i].ToString("F2"));
       }
    }
}
