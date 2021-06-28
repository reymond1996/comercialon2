using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comercialon.Classes
{
    class Marca
    {

        public string Nome { get; set; }
        public string Sigla { get; set; }
        public Marca()
        {
        }

        public Marca(string nome, string sigla)
        {
            Nome = nome;
            Sigla = sigla;
        }
    }

}