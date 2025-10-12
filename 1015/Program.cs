using System;
using System.Globalization;

class URI
{
    static void Main(string[] args)
    {
     
        double[] x = new double[2];
        double[] y = new double[2];

        string[] x1y1 = Console.ReadLine().Split(' ');
        string[] x2y2 = Console.ReadLine().Split(' ');
            
        x[0] = double.Parse(x1y1[0], CultureInfo.InvariantCulture);
        y[0] = double.Parse(x1y1[1], CultureInfo.InvariantCulture);
        x[1] = double.Parse(x2y2[0], CultureInfo.InvariantCulture);
        y[1] = double.Parse(x2y2[1], CultureInfo.InvariantCulture);


        double distancia = Math.Sqrt(
                                     (Math.Pow(x[1] - x[0], 2)) + 
                                     (Math.Pow(y[1] - y[0], 2))
                                     );
        
        Console.WriteLine(distancia.ToString("F4", CultureInfo.InvariantCulture));
        Console.ReadLine();
    }
}