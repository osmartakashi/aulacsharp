using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetosTipos
{
    public class Singleton
    {
        private static Singleton s_instance;
        private int _state;

        //private Singleton(int state)
        //{
        //    _state = state;
        //}
        //ou
        private Singleton(int state) => _state = state;

        public static Singleton Instance
        {
            get => s_instance ?? (s_instance = new Singleton(30));
        }
    }
}
