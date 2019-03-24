using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace AulaCSharp
{
    public class Calculadora
    {
        private const double pi = 3.14159;//pi

        public double CalcularAreaCircunferencia(double raio)
        {
            double area;
            area = pi * (Math.Pow(raio, 2));
            return area;
        }

        public double CalcularAreaTriangulo(double @base, double altura)
        {
            var area = (@base * altura) / 2;
            return area;
        }

        public void CalcularQualquerCoisa(Referencia referencia)
        {
            referencia.ValorA = 10;
            referencia.ValorB = 20;
        }

        public void CalcularQualquerCoisa2(ref Referencia referencia)
        {
            referencia.ValorB = 55;
        }

        public void AlterarValores(int valorA, int valorB)
        {
            valorA = 10;
            valorB = 20;

        }

        internal void AlterarValoresReferencia(ref int valorA,ref int valorB)
        {
            valorA = 10;
            valorB = 20;
        }
    }
}
