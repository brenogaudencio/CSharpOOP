using System;
using System.Globalization;
using Produtos;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto p1 = new Produto("Tv", 500.0, 5);
            p1.Nome = ("Tv Samsung");

            Produto p = new Produto("Geladeira", 1000.0, 1);
            Console.WriteLine("Produto: " + p.Nome);
            Console.WriteLine(p.Preco);
            Console.WriteLine(p.Quantidade);
            Console.WriteLine(p1);
        }
    }
} 