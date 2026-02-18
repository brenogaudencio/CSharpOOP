using System;
using System.Globalization;
using Banco;

namespace MyApp
{
    internal class Conta
    {
        static void Main(string[] args)
        {
            

            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char resposta = char.Parse(Console.ReadLine());
            if (resposta == 's' || resposta == 'S') {
                Console.Write("Entre o valor do depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
        }
    }
}