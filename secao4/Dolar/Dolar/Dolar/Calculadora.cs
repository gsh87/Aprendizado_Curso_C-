using System.Globalization;

namespace Dolar
{
    class Calculadora
    {
        public static double Valores(double dolar, double volume)
        {
            return dolar * volume * (1.06);
        }
    }
}
