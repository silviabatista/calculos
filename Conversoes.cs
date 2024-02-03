using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    /// <summary>
    /// Implemnta operações de conversão.
    /// </summary>
    internal static class Conversoes
    {
        /// <summary>
        /// Tipos de Conversao de Temperatura a executar
        /// </summary>
        public enum ConversaoTemperatura
        {
            Nulo = 0;
            CelsiusFahrenheit,
            FahrenhitCelsius
        }

        /// <summary>
        /// Conversão de temperaturas.
        /// </summary>
        /// <param name="conversao"> A conversão a efetuar.</param>
        /// <param name="temperatura">A temperatyra a converter.</param>
        /// <returns>Retorna o resultado da conversão.</returns>
        public static double ConnverterTemperatura(ConversaoTemperatura conversao, double temperatura)
        {
            if (conversao == ConversaoTemperatura.CelsiusFahrenheit)
            {
                return (temperatura * 1.8000 + 32);
            }
            else if (conversao == ConversaoTemperatura.FahrenhitCelsius)
            {
                return ((temperatura - 32) / 1.8000);
            }
            return -1;

        }
    }
}
