using System;
using Excalsse02;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario x, y;

            x = new Funcionario();  
            y = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.Write("Nome: ");
            x.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            x.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Dados do segundo funcionário: ");
            Console.Write("Nome: ");
            y.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            y.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salarioMedio = (x.Salario + y.Salario) / 2.0;

            Console.WriteLine("Salário médio = " + salarioMedio.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}