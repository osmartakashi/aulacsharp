using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Objetos
{
    public interface ITributavel
    {
        decimal CalcularTributo(decimal valor);
    }
}
