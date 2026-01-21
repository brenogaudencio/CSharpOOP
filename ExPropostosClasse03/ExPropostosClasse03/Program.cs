using ExPropostosClasse03;
using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno x;

            x = new Aluno();

            Console.Write("Nome do aluno: ");
            x.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            x.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("NOTA FINAL = " + x.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));

            if (x.Aprovado())
            {
                Console.WriteLine("APROVADO");
            }
            else {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM " + x.NotaRestante().ToString("F2", CultureInfo.InvariantCulture) + " PONTOS");
            }
        }
    }
}