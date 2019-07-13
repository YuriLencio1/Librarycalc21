using System;
using System.Collections.Generic;
using System.Text;

namespace librarycalc21
{
    /// <summary>
    /// interface para calculos simples
    /// </summary>
    interface ICalculadora
    {
        /// <summary>
        /// soma de valores
        /// </summary>
        /// <param name="x">valor inteiro</param>
        /// <param name="y">valor inteiro</param>
        /// <returns>resultado da soma</returns>
        int somar(int x, int y);
        
        /// <summary>
        /// subtração de valores
        /// </summary>
        /// <param name="x">valor inteiro</param>
        /// <param name="y">valor inteiro</param>
        /// <returns>resultado da subtração</returns>
        int subtrair(int x, int y);
        
        /// <summary>
        /// multiplicaçao de valores
        /// </summary>
        /// <param name="x">valor inteiro</param>
        /// <param name="y">valor inteiro</param>
        /// <returns>resultado da subtração</returns>
        int multiplicar(int x, int y);

        /// <summary>
        /// divisão de valores
        /// </summary>
        /// <param name="x">valor inteiro</param>
        /// <param name="y">valor inteiro</param>
        /// <returns>resultado da divisão</returns>
        double dividir(double x, double y);

        /// <summary>
        /// soma de tres valores
        /// </summary>
        /// <param name="x">valor inteiro</param>
        /// <param name="y">valor inteiro</param>
        /// <param name="z">valor inteiro</param>
        /// <returns>resultado da soma de tres valores</returns>
        int somar(int x, int y, int z);

        /// <summary>
        /// subtraçao de tres valores
        /// </summary>
        /// <param name="x">valor inteiro</param>
        /// <param name="y">valor inteiro</param>
        /// <param name="z">valor inteiro</param>
        /// <returns></returns>
        int subtrair(int x, int y, int z);

        /// <summary>
        /// multiplicar tres valores
        /// </summary>
        /// <param name="x">valor inteiro</param>
        /// <param name="y">valor inteiro</param>
        /// <param name="z">valor inteiro</param>
        /// <returns></returns>
        int multiplicar(int x, int y, int z);
    }
}
