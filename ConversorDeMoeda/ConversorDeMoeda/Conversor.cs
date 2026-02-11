namespace ConversorDeMoeda
{
    internal static class Conversor
    {
        public static double Dolar = 3.10; // exemplo de cotação

        public static double ValorReal(double d) { 
            return d * Dolar;
        }

        public static double ValorTaxado(double b) {
            return b * 1.06; // exemplo de taxa de 6%
        }
    }
}
