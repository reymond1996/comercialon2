using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comercialon.Classes
{
    public class ItemPedido
    {
        private readonly int idPedido;
        public Pedido Pedido { get; set; }
        public int IdPedido { get { return idPedido; } }
        public double Quantidade { get; set; }
        public double ValorProduto { get; set; }
        public double Desconto { get; set; }

        public ItemPedido(int idPedido, Pedido pedido, double quantidade, double valorProduto, double desconto)
        {
            this.idPedido = idPedido;
            Pedido = pedido;
            Quantidade = quantidade;
            ValorProduto = valorProduto;
            Desconto = desconto;
        }

        public ItemPedido()
        {
        }
        public static List<ItemPedido> ObterItemsPedido()
        {
            List<ItemPedido> lista = new List<ItemPedido>();
            
            return lista;
        }
        public void Inserir()
        {

        }
    }


}
