using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrcamentoFacil.Telas
{
    public partial class frmClientes : Form
    {
        frmTelaPrincipal frmTelaPrincipal;
        public string destinoCompleto;
        List<ModeloCliente> cliente;
        public static ModeloCliente clienteSelecionado;
        public frmClientes(frmTelaPrincipal frmPrincipal)
        {
            InitializeComponent();
            frmTelaPrincipal = frmPrincipal;
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            BuscarClientes();
        }

        public void BuscarClientes()
        {
            cliente = BLL.ClientesBLL.BuscarClientes();
            dtGridClientes.DataSource = cliente;
            if (cliente.Count > 0)
            {
                clienteSelecionado = cliente[0];
                PopulaCampos(clienteSelecionado);
            }
        }

        private void PopulaCampos(ModeloCliente cliente)
        {
            txtNome.Text = cliente.NomeCliente;
            txtContato.Text = cliente.Contato;
            txtTelefone.Text = cliente.Telefone;
            txtCep.Text = cliente.Cep;
            txtRua.Text = cliente.Logradouro;
            txtNumero.Text = cliente.Numero;
            txtBairro.Text = cliente.Bairro;
            txtCidade.Text = cliente.Cidade;
            txtComplemento.Text = cliente.Complemento;
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            frmTelaPrincipal.AtivaDesativaBotoes(this, true);
        }

        public void ExcluirCliente()
        {
            if(clienteSelecionado.IdCliente != 0)
            {
                BLL.ClientesBLL.ExcluirCliente(clienteSelecionado.IdCliente, clienteSelecionado.IdEndereco);
                BuscarClientes();
            }
        }

        public void SalvarCliente()
        {
            try
            {
                clienteSelecionado.NomeCliente = txtNome.Text;
                clienteSelecionado.Contato = txtContato.Text;
                clienteSelecionado.Telefone = txtTelefone.Text;
                clienteSelecionado.Cep = txtCep.Text;
                clienteSelecionado.Logradouro = txtRua.Text;
                clienteSelecionado.Numero = txtNumero.Text;
                clienteSelecionado.Bairro = txtBairro.Text;
                clienteSelecionado.Cidade = txtCidade.Text;
                clienteSelecionado.Complemento = txtComplemento.Text;

                BLL.ClientesBLL.SalvarCLiente(clienteSelecionado);
                BuscarClientes();
                MessageBox.Show("Salvo com sucesso", "Salvar Cliente");
            }
            catch (Exception)
            {
                MessageBox.Show("Falha ao tentar salvar registro", "Salvar Cliente");
            }
        }

        public void Incluir()
        {
            clienteSelecionado.IdCliente = 0;
            clienteSelecionado.IdEndereco = 0;
            ZerarCampos();
        }

        private void ZerarCampos()
        {
            txtNome.Text = string.Empty;
            txtContato.Text = string.Empty;
            txtTelefone.Text = string.Empty;
            txtCep.Text = string.Empty;
            txtRua.Text = string.Empty;
            txtNumero.Text = string.Empty;
            txtBairro.Text = string.Empty;
            txtCidade.Text = string.Empty;
            txtComplemento.Text = string.Empty;
        }
        private void dtGridClientes_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            clienteSelecionado = cliente[e.RowIndex];
            PopulaCampos(clienteSelecionado);
        }
    }
}
