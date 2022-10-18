using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Funcoes;
using Modelo;

namespace OrcamentoFacil.Telas
{
    public partial class frmOrcamentos : Form
    {
        List<ModeloProduto> listProdutos = new List<ModeloProduto>();
        List<ModeloCliente> listaClientes = new List<ModeloCliente>();
        ModeloProduto prodSelecionado = new ModeloProduto();

        public frmOrcamentos()
        {
            InitializeComponent();
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.AceitarSomenteNumerosDouble(e, txtQuantidade);
        }

        private void frmOrcamentos_Load(object sender, EventArgs e)
        {
            CarregaCampos();
        }

        public void CarregaCampos()
        {
            listProdutos = BLL.ProdutoBLL.Buscar();
            cbProduto.DataSource = listProdutos;
            cbProduto.DisplayMember = "NomeConcat";
            cbProduto.ValueMember = "IdProduto";
            cbProduto.Text = string.Empty;

            listaClientes = BLL.ClientesBLL.BuscarClientes();
            cbCliente.DataSource = listaClientes;
            cbCliente.DisplayMember = "NomeConcat";
            cbCliente.ValueMember = "IdCliente";
            cbCliente.Text = string.Empty;

        }

        public void CarregaProdutoSelecionado(int idProduto)
        {
            prodSelecionado = listProdutos.Find(x => x.IdProduto == idProduto);

            txtUnd.Text = prodSelecionado.Sigla;
            txtValor.Text = prodSelecionado.Valor.ToString();
        }

        private void cbProduto_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbProduto.Text))
                CarregaProdutoSelecionado(((Modelo.ModeloProduto)((System.Windows.Forms.ListControl)sender).SelectedValue).IdProduto);
        }
    }
}
