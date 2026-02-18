using System;
using System.Globalization;
using Produtos;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("Tv", 500.0, 5);
            p.Nome = ("Tv Samsung");
            

            Console.WriteLine("Produto: " + p.Nome);
            Console.WriteLine(p.Preco);
            Console.WriteLine(p.Quantidade);
        }
    }
} 