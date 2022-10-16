using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Funcoes;
using Modelo;
namespace OrcamentoFacil.Telas
{
    public partial class frmTabProduto : Form
    {
        List<ModeloProduto> produtos = new List<ModeloProduto>();
        ModeloProduto produtoSelecionado = new ModeloProduto();
        List<ModeloUnidadeMedida> unidadeMedida = new List<ModeloUnidadeMedida>();
        public frmTelaPrincipal Owner;

        public frmTabProduto(frmTelaPrincipal frm)
        {
            Owner = frm;
            InitializeComponent();
        }

        private void txtValorProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.AceitarSomenteNumerosDouble(e, txtValorProduto);
        }

        private void frmTabProduto_Load(object sender, System.EventArgs e)
        {
            BuscarProdutos();
        }

        public void BuscarProdutos()
        {
            produtos = BLL.ProdutoBLL.Buscar();
            dtGridProtudos.DataSource = produtos;

            unidadeMedida = BLL.UnidadeMedidaBLL.BuscarUnidadesMedida();
            cbUnidadeMedida.DataSource = unidadeMedida;
            cbUnidadeMedida.DisplayMember = "Sigla";
            cbUnidadeMedida.ValueMember = "IdUnidadeMedida";
            cbUnidadeMedida.Text = "";

            if (produtos.Count > 0)
            {
                produtoSelecionado = produtos[0];
                PopulaCampos(produtoSelecionado);
            }
        }

        public void PopulaCampos(ModeloProduto produto)
        {
            txtDescricao.Text = produto.Descricao;
            txtValorProduto.Text = produto.Valor.ToString();
            cbUnidadeMedida.Text = produto.UnidadeMedida.Sigla;
        }

        private void dtGridProtudos_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            produtoSelecionado = produtos[e.RowIndex];
            PopulaCampos(produtoSelecionado);
        }

        public void Incluir()
        {
            produtoSelecionado.IdProduto = 0;
            ZerarCampos();
        }

        public void ZerarCampos()
        {
            txtDescricao.Text = string.Empty;
            txtValorProduto.Text = string.Empty;
            cbUnidadeMedida.Text = string.Empty;
        }

        public void Salvar()
        {
            ModeloProduto prod = new ModeloProduto();
            prod.IdProduto = produtoSelecionado.IdProduto;
            prod.Descricao = txtDescricao.Text;
            prod.Valor = Convert.ToDouble(txtValorProduto.Text);
            prod.UnidadeMedida.IdUnidadeMedida = ((ModeloUnidadeMedida)cbUnidadeMedida.SelectedItem).IdUnidadeMedida;
            int idInserido = BLL.ProdutoBLL.Inserir(prod);
            if (idInserido > 0)
            {
                MessageBox.Show("Registro salvo com sucesso", "Salvar Produto");
            }
            else
            {
                MessageBox.Show("Falha ao Inserir registro", "Salvar Produto");
            }
            BuscarProdutos();
        }

        public void Excluir()
        {
            try
            {
                if(produtoSelecionado.IdProduto > 0)
                {
                    BLL.ProdutoBLL.Excluir(produtoSelecionado.IdProduto);
                    MessageBox.Show("Registro Excluído Com Sucesso!", "Excluir Cadastro de Produto");
                }
                BuscarProdutos();
            }
            catch (Exception)
            {
                MessageBox.Show("Falha ao excluir registro", "Excluir Cadastro de Produto");
            }
        }

        private void cbUnidadeMedida_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            Owner.EmEdicao();
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Owner.EmEdicao();
            if(((Control)sender).Name == "txtValorProduto")
                Utils.AceitarSomenteNumerosDouble(e, txtValorProduto);
        }
    }
}
