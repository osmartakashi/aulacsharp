using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2
{
    public class Pessoa
    {
        //fields e propriedades
        //private string _nome;

        //public string Nome
        //{
        //    get { return _nome; }
        //    set { _nome = value; }
        //}
        private int _tipoPessoa;
        public static string Cpf { get;private set; }
        //public Pessoa()
        //{
        //    Nome = "João";
        //    Sobrenome = "Das Couves";
        //}

        public Pessoa(string nome , int tipoPessoa)
        {
            Nome = nome;
            _tipoPessoa = tipoPessoa;
        }
        //constructor initializer
        public Pessoa(string nome): this(nome,1)
        {
           
        }

        //public Pessoa(string nome, string sobrenome, string nomeCompleto = null)
        //{
        //    Nome = nome;
        //    Sobrenome = sobrenome;
        //    if (!string.IsNullOrEmpty(nomeCompleto))
        //    {
        //        NomeCompleto = nomeCompleto;
        //    }
        //}

         static Pessoa()
         {
             Cpf = "1234565555";
         }

        public string Nome { get; set; }//propriedade auto implementada
        public string Sobrenome { get; set; }

        public string NomeCompleto
        {
            get { return $"{Nome} {Sobrenome}"; }
            private set { }
        }

        public string ValidoStr { get; set; }

        public bool Valido => ValidoStr == "1" ;
    }
}
