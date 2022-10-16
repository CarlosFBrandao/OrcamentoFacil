using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Modelo;

namespace OrcamentoFacil
{
    public partial class frmTabUnidadeMedida : Form
    {
        ModeloUnidadeMedida unidadeMedidaSelecionado = new ModeloUnidadeMedida();
        List<ModeloUnidadeMedida> unidades = new List<ModeloUnidadeMedida>();
        public frmTabUnidadeMedida()
        {
            InitializeComponent();
        }

        public void Salvar()
        {
            ModeloUnidadeMedida und = new ModeloUnidadeMedida();
            und.Descricao = txtDescricao.Text;
            und.Sigla = txtSigla.Text;
            int idInserido = BLL.UnidadeMedidaBLL.Salvar(und);
            if (idInserido > 0)
            {
                MessageBox.Show("Registro salvo com sucesso", "Salvar Unidade Medida");
            }
            else
            {
                MessageBox.Show("Falha ao Inserir registro", "Salvar Unidade Medida");
            }
            BuscarUnidades();
        }

        public void BuscarUnidades()
        {
            unidades = BLL.UnidadeMedidaBLL.BuscarUnidadesMedida();
            dtGridUnidadeMedida.DataSource = unidades;
            if (unidades.Count > 0)
            {
                unidadeMedidaSelecionado = unidades[0];
                PopulaCampos(unidadeMedidaSelecionado);
            }
        }

        public void PopulaCampos(ModeloUnidadeMedida und)
        {
            txtSigla.Text = und.Sigla;
            txtDescricao.Text = und.Descricao;
        }

        private void frmTabUnidadeMedida_Load(object sender, EventArgs e)
        {
            BuscarUnidades();
        }

        private void dtGridUnidadeMedida_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            unidadeMedidaSelecionado = unidades[e.RowIndex];
            PopulaCampos(unidadeMedidaSelecionado);
        }

        private void ZerarCampos()
        {
            txtDescricao.Text = string.Empty;
            txtSigla.Text = string.Empty;
        }

        public void ExcluirUnidadeMedida()
        {
            try
            {
                if (unidadeMedidaSelecionado.IdUnidadeMedida > 0)
                {
                    string retorno = BLL.UnidadeMedidaBLL.Excluir(unidadeMedidaSelecionado.IdUnidadeMedida);
                    BuscarUnidades();
                    MessageBox.Show(retorno , "Excluir Undiade Medida");
                }
                else
                {
                    MessageBox.Show("Nenhum Registro a ser excluído", "Excluir Undiade Medida");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Falha ao excluir registro", "Excluir Undiade Medida");
            }
        }

        public void Incluir()
        {
            unidadeMedidaSelecionado.IdUnidadeMedida = 0;
            ZerarCampos();
        }
    }
}
