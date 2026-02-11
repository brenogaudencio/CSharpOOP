using System;
using ConversorDeMoeda;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar? " + Conversor.Dolar.ToString("F2"));

            Console.WriteLine();
            Console.Write("Quantos dólares você vai comprar? ");
            double quantidade = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double valorEmReais = Conversor.ValorReal(quantidade);
            double valorTaxado = Conversor.ValorTaxado(valorEmReais);
            Console.Write("Valor a ser pago em reais = $" + valorTaxado.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
