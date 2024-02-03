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
            Nulo = 0,
            CelsiusFahrenheit,
            FahrenhitCelsius
        }

        /// <summary>
        /// Tipos de Conversão de distâncias
        /// </summary>
        public enum ConversaoDistancia
        {
            Nulo = 0,
            MetrosMilhas,
            MilhasMetros
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
        /// <summary>
        /// Conversão de distâncias.
        /// </summary>
        /// <param name="conversao">A conversao a efetuar.</param>
        /// <param name="distancia">A conversao a converter.</param>
        /// <returns></returns>
        public static double ConverterDistancias(ConversaoDistancia conversao, double distancia)
        { 
            if (conversao == ConversaoDistancia.MetrosMilhas) 
            {
                return distancia * 0.0006213712;
            }
            else if (conversao == ConversaoDistancia.MilhasMetros)
            {
                return distancia * 1609.344;
            }
            return -1;

        }
    }
}
