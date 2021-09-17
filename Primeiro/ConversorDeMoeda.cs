namespace Primeiro
{
    class ConversorDeMoeda
    {
        public static double Iof = 0.06;

        public static double ValorAPagar(double cotacao, double reais)
        {
            double pagar = cotacao * reais;
            pagar *= (1 + Iof);
            return pagar;
        }
    }
}
