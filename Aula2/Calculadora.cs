using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2
{
    static class Calculadora
    {
        /*
         * A calculadora deverá ter 4 operações:
         Adição, subtração, multiplicação e divisão
         */
        /// <summary>
        /// Este método retorna o resultado de uma soma
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static double Somar(double n1, double n2)
        {
            return n1 + n2;
        }

        public static double Somar(double n1, double n2, double n3)
        {
            return n1 + n2 - n3;
        }

        public static double Somar(double n1, double n2, double n3, double n4)
        {
            return n1 + n2 + n3 + n4;
        }

        public static void CalcularNumeros(double v1, double v2, out double resultadoSoma, out double resultadoSubtracao)
        {
            resultadoSoma = v1 + v2;
            resultadoSubtracao = v1 - v2;
        }

        public static double Subtrair(double n1,double n2, double n3 = 0)
        {
            if (n3 != 0)
            {
                return n1 - n2 - n3;
            }
            return n1 - n2;
        }

        //public double Multiplicar(double n1, double n2) => n1 * n2;
      

        //public bool Iguais(int v1, int v2) => v1 == v2;

        //public double Dividir(double n1, double n2)
        //{
        //    return n1 / n2;
        //}

        //public double SomarVarios(params double[] valores)
        //{
        //    double result = 0;
        //    foreach (var valor in valores)
        //    {
        //        result += valor;
        //    }

        //    return result;
        //}

    }
}
