using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comercialon.Classes
{
    public class Produto
    {

        public int Id { get; set; }
        public string Descricao { get; set; }
        public double Valor_Unitario { get; set; }
        public string Unidade_Venda { get; set; }
        public string CodBar { get; set; }
        public double Desconto { get; set; }
        public bool Descontinuado { get; set; }
        public Marca Marca { get; set; }
        public Categorias Categorias { get; set; }


        public Produto() { Id = 0; }

        public Produto(string descricao, double valor_Unitario, string unidade_Venda, string codBar, double desconto, bool descontinuado, Marca marca, Categorias categorias)
        {
            Descricao = descricao;
            Valor_Unitario = valor_Unitario;
            Unidade_Venda = unidade_Venda;
            CodBar = codBar;
            Desconto = desconto;
            Descontinuado = descontinuado;
            Marca = marca;
            Categorias = categorias;
        }

        public Produto(int id, string descricao, double valor_Unitario, string unidade_Venda, string codBar, double desconto, bool descontinuado, Marca marca, Categorias categorias)
        {
            Id = id;
            Descricao = descricao;
            Valor_Unitario = valor_Unitario;
            Unidade_Venda = unidade_Venda;
            CodBar = codBar;
            Desconto = desconto;
            Descontinuado = descontinuado;
            Marca = marca;
            Categorias = categorias;
        }

        public void Inserir()
        { }
        public static List<Produto> ObterLista()
        {
            List<Produto> lista = new List<Produto>();

            return lista;
        }
        public void BuscarPorId(int id)
        {

        }
        public void BuscarPorIdCodBar(string CodBar)
        {

        }
        public bool Alterar()
        {
            return true;
        }
        
        
        

    }
}

   
