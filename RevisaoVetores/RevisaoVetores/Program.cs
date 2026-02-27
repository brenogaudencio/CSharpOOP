using System;
using System.Globalization;

namespace RevisaoVetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double[] alturas = new double[n];
            double total = 0.0;

            for (int i = 0; i < n; i++)
            {
                alturas[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                total += alturas[i];
            }

            
            Console.WriteLine(total.ToString("F2", CultureInfo.InvariantCulture) + "Mts");
            
        }
    }
}
