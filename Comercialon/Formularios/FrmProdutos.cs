using Comercialon.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comercialon.Formularios
{
    public partial class FrmProdutos : Form
    {
        public FrmProdutos()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dgvListarMarca_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnMarca_Click(object sender, EventArgs e)
        {
            Marca marca = new Marca(
                txtMarca.Text,
                txtSiglaMarca.Text
                );
            marca.Inserir();

        }

        private void listarMarca_Click(object sender, EventArgs e)
        {
            dgvListarMarca.Rows.Clear();
            var lista = Marca.ObterMarcas();
            foreach(var item in lista)
            {
                dgvListarMarca.Rows.Add();
                dgvListarMarca.Rows[dgvListarMarca.Rows.Count - 1].Cells[0].Value = item.id;
                dgvListarMarca.Rows[dgvListarMarca.Rows.Count - 1].Cells[1].Value = item.Nome;
                dgvListarMarca.Rows[dgvListarMarca.Rows.Count - 1].Cells[2].Value = item.Sigla;
            }
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            Categorias categorias = new Categorias(
                txtCat.Text,
                txtSiglaCat.Text
                );
            categorias.Inserir();
        }
    }
}
