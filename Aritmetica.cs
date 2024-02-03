using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{/// <summary>
/// Implementa operações aritméticas.
/// </summary>
    internal class Aritmetica
    {
        /// <summary>
        /// Tipos de Conversao de Temperatura a executar
        /// </summary>
        public enum ConversaoTemperatura
        { 
            Nulo =0;
            CelsiusFahrenheit,
            FahrenhitCelsius
        }

        /// <summary>
        /// Operação Soma
        /// </summary>
        /// <returns>Retorna a soma de 2 numeros</returns>
        public int Somar(int x, int y)
        { 
            return x * y;
        }
        /// <summary>
        /// Operação de subtração
        /// </summary>
        /// <returns>Retorna o resultado da subtração de 2 numeros</returns>
        public int Subtrair(int x, int y)
        {
            return x - y;
        }

        public double ConnverterTemperatura(ConversaoTemperatura conversao, double temperatura)
        {
           if (conversao == ConversaoTemperatura.CelsiusFahrenheit)
            {
                return (temperatura * 1.8000 + 32);
            }
           else if (conversao == ConversaoTemperatura.FahrenhitCelsius)
            {
                return ((temperatura - 32)/1.8000);
            }
            return -1;

        }

    }
}
