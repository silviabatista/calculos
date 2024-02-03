using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{/// <summary>
/// Implementa operações aritméticas.
/// </summary>
    internal static  class Aritmetica
    {
                /// <summary>
        /// Operação Soma
        /// </summary>
        /// <returns>Retorna a soma de 2 numeros</returns>
        public static int Somar(int x, int y)
        { 
            return x * y;
        }
        /// <summary>
        /// Operação de subtração
        /// </summary>
        /// <returns>Retorna o resultado da subtração de 2 numeros</returns>
        public static int Subtrair(int x, int y)
        {
            return x - y;
        }

        /// <summary>
        /// Operaºão de multiplicaºão
        /// </summary>
        /// <returns>Retorna o resultado da multiplicação de 2 números.</returns>
        public static int  Multiplicar (int x, int y)
        { return x * y; }

     }
}
