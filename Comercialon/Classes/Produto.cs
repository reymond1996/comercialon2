using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comercialon.Classes
{
    class Produto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public decimal Valor_unitario { get; set; }
        public string unidade_venda { get; set; }
        public  string codbar { get; set; }
        public decimal desconto { get; set; }
        public List<Marca> Marca { get; set; }
        public List<Categorias> Categorias { get; set; }
        public bool descontinuado { get; set; }

        public Produto() { Id = 0; }

        public Produto(string descricao, decimal valor_unitario, string unidade_venda, string codbar, decimal desconto, List<Marca> marca, List<Categorias> categorias, bool descontinuado)
        {
            Descricao = descricao;
            Valor_unitario = valor_unitario;
            this.unidade_venda = unidade_venda;
            this.codbar = codbar;
            this.desconto = desconto;
            Marca = marca;
            Categorias = categorias;
            this.descontinuado = descontinuado;
        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            if(cmd.Connection.State == System.Data.ConnectionState.Open)
               {
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "insert categorias" +
                " (nome,sigla) " +
                " values('"+Nome+"', '"+Sigla+"');";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "select @@identity";
                Id = Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
    }
}
