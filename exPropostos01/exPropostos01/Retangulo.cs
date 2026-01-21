using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace exPropostos01
{
    internal class Retangulo
    {
        public double Altura;
        public double Largura;

        public double Area() {
            return Altura * Largura;
        }

        public double Perimetro() { 
            return 2 * (Altura + Largura);
        }

        public double Diagonal() {
            return Math.Sqrt(Altura * Altura + Largura * Largura);
        }

        override public string ToString() {
            return "AREA: " + Area().ToString("F2",CultureInfo.InvariantCulture) + "\n" +
                   "PERIMETRO: " + Perimetro().ToString("F2", CultureInfo.InvariantCulture) + "\n" +
                   "DIAGONAL: " + Diagonal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
