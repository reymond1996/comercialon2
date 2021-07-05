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
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            if(cmd.Connection.State==System.Data.ConnectionState.Open)
            {
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = " insert categorias " + "(nome,sigla)" + "values('"+Nome+"','"+Sigla+"');";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "select @@identity";
                Id = Convert.ToInt32(cmd.ExecuteScalar());
            }
    
        }

       
        public static List<Categorias> ObterListaCategorias()
        {
            List<Categorias> listar = new List<Categorias>();
            {
                string query = "select * from categorias";
                var cmd = Banco.Abrir();
                cmd.CommandText = query;
                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    listar.Add(new Categorias(
                        dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetString(2)
                        ));
                }
            }
            return listar;
        }
    }

}
