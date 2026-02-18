using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Banco
{
    internal class ContaBancaria
    {
        public int NumeroDaConta { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numeroDaConta, string titular)
        {
            NumeroDaConta = numeroDaConta;
            Titular = titular;
        }

        public ContaBancaria(int numeroDaConta, string titular, double saldo) : this(numeroDaConta, titular) {
            Saldo = saldo;
        }

        public override string ToString()
        {
            return "Conta " 
                + NumeroDaConta 
                + ", Titular: " 
                + Titular 
                + ", Saldo: $" 
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
     }
}

