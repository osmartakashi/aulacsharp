using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjetosTipos.Contas;

namespace ObjetosTipos
{
    public static class Extensions
    {
        public static decimal ToDecimal(this string str)
        {
            return Convert.ToDecimal(str);
        }

        public static string ToStringFormatada(this decimal value)
        {
            return value.ToString("C");
        }
    }
}
