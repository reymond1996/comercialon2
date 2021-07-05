using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Comercialon.Classes;

namespace Comercialon.Classes
{
    public class Marca
    {
        public int id { get; set; }
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

        public Marca(int id, string nome, string sigla)
        {
            this.id = id;
            Nome = nome;
            Sigla = sigla;
        }

        public Marca(object p)
        {
        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            if(cmd.Connection.State== System.Data.ConnectionState.Open)
            {
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = " insert marcas " + "(nome,sigla)" +
                    "values('" + Nome + "','" + Sigla + "')";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "select @@identity";
                id = Convert.ToInt32(cmd.ExecuteScalar());
            }
            
        }
        public static List<Marca> ObterMarcas()
        {
            List<Marca> lista = new List<Marca>();
            {
                
                string query = "select * from marcas";
                var cmd = Banco.Abrir();
                cmd.CommandText = query;
                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new Marca(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2)
                    ));
                }
                
            }
            return lista;
        }
    }

}