using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetosTipos
{
    public class Car
    {
        private int _numRodas;
        private string _marca;
        private string _modelo;

        public Car(int numRodas, string marca, string modelo)
        {
            this._marca = marca;
            this._modelo = modelo;
            this._numRodas = numRodas;
        }

        public Car(string modelo) : this(4,"Ford",modelo)
        {
            
        }
    }
}
