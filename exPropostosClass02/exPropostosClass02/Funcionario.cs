using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace exPropostosClass02
{
    internal class Funcionario
    {
        public string Nome;
        public double SalarioB;
        public double Imposto;
       

        public double SalarioL() {
            return SalarioB - Imposto;
        }
        

        public void AumentarSalario(double porcentagem) { 
            SalarioB += SalarioB * porcentagem / 100.0;
        }

        public override string ToString()
        {
            return Nome + ", $ " + SalarioL().ToString("F2", CultureInfo.InvariantCulture);
        }
    } 
}
