using exPropostosClass02;
using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario x;

            x = new Funcionario();

            Console.Write("Nome: ");
            x.Nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            x.SalarioB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            x.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Funcionário: " + x);

            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double Porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.AumentarSalario(Porcentagem);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + x);

        }
    }
}