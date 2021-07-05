using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comercialon.Classes
{
    public class Categorias
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }

        public Categorias()
        {

        }

        public Categorias(int id, string nome, string sigla)
        {
            Id = id;
            Nome = nome;
            Sigla = sigla;
        }

        public Categorias(string nome, string sigla)
        {
            Nome = nome;
            Sigla = sigla;
        }
        public Categorias(int id)
        {
            Id = id;
        }
       
        public static List<Categorias> ObterListaCategorias()
        {
            List<Categorias> listar = new List<Categorias>();
            return listar;
        }
    }

}
