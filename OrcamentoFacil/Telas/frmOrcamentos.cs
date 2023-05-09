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
        ModeloLancamento lancamento = new ModeloLancamento();

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
            if (cbProduto.Text == string.Empty)
            {
                LimpaCampos();
            }
            else
            {
                prodSelecionado = listProdutos.Find(x => x.IdProduto == idProduto);

                txtUnd.Text = prodSelecionado.Sigla;
                txtValorProd.Text = prodSelecionado.Valor.ToString();
            }
        }

        private void LimpaCampos() {
            cbProduto.Text = string.Empty;
            txtValorProd.Text = string.Empty;
            txtUnd.Text = string.Empty;
            txtQuantidade.Text = string.Empty;
        }

        private void cbProduto_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbProduto.Text)) {
                int idProduto = ((ModeloProduto)((ComboBox)sender).SelectedItem).IdProduto;
                CarregaProdutoSelecionado(idProduto);
            }
        }

        private void btnAdicionarProduto_Click(object sender, EventArgs e)
        {
            var item = cbCliente.Text;
            if (cbCliente.Text == string.Empty)
            {
                MessageBox.Show("Antes de adicionar um produto, selecione o cliente", "Adicionar Produto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (cbProduto.Text == string.Empty)
            {
                MessageBox.Show("Selecione um produto", "Adicionar Produto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else if (txtQuantidade.Text == string.Empty || Convert.ToDouble(txtQuantidade.Text) <= 0)
            {
                MessageBox.Show("Informe a quantidade maior que zero!", "Adicionar Produto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                int idCliente = ((ModeloCliente)cbCliente.SelectedItem).IdCliente;
                int idProduto = ((ModeloProduto)cbProduto.SelectedItem).IdProduto;

                if (lancamento.Cliente == null)
                {
                    lancamento.Cliente = new ModeloCliente(idCliente: idCliente);
                    cbCliente.Enabled = false;
                }
                double quantidade = string.IsNullOrEmpty(txtQuantidade.Text) ? 0 : Convert.ToDouble(txtQuantidade.Text);
                double valor = string.IsNullOrEmpty(txtValorProd.Text) ? 0 : Convert.ToDouble(txtValorProd.Text);
                ModeloProduto prod = new ModeloProduto(
                    idProduto: idProduto,
                    descricao: prodSelecionado.Descricao,
                    valorProduto: valor,
                    quantidade: quantidade,
                    sigla: prodSelecionado.Sigla,
                    valorTotal: valor * quantidade
                    );


                lancamento.Produtos.Add(prod);
                AtualizaGrid();
                LimpaCampos();
            }
        }

        private void AtualizaGrid()
        {
            List<ModeloListaProdutos> listaProd = new List<ModeloListaProdutos>();

            foreach(var item in lancamento.Produtos)
            {
                listaProd.Add(new ModeloListaProdutos(
                    idProduto: item.IdProduto,
                    descricao: item.Descricao,
                    unidadeMedida: item.UnidadeMedida.Sigla,
                    quantidade: item.Quantidade,
                    valor: item.Valor,
                    valorTotal: item.ValorTotal
                    )) ;
            }

            dtGridProtudos.DataSource = listaProd;
            
        }

        private void dtGridProtudos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
