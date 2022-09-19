using System;
using System.Collections.Generic;
using Modelo;
using BLL;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrcamentoFacil.Telas
{
    public partial class frmEmpresa : Form
    {
        frmTelaPrincipal frmTelaPrincipal;
        public string destinoCompleto;

        public frmEmpresa(frmTelaPrincipal frmPrincipal)
        {
            InitializeComponent();
            frmTelaPrincipal = frmPrincipal;
        }
        public void ExibeOcultaBotoes()
        {
            frmTelaPrincipal.btnSalvar.Enabled = true;
            frmTelaPrincipal.btnCancelar.Enabled = true;
        }

        public void PopulaCampos()
        {
            List<ModeloEmpresa> empesa = new EmpresaBLL().BuscarEmpresa();
            if (empesa.Count > 0)
            {
                foreach (var emp in empesa)
                {
                    txtEmpresa.Text = emp.NomeEmpresa;
                    txtContato.Text = emp.Contato;
                    txtTelefone.Text = emp.Telefone;
                    txtCep.Text = emp.Cep;
                    txtRua.Text = emp.Logradouro;
                    txtNumero.Text = emp.Numero;
                    txtBairro.Text = emp.Bairro;
                    txtUf.Text = emp.Uf;
                    txtCidade.Text = emp.Cidade;
                    txtComplemento.Text = emp.Complemento;
                    destinoCompleto = emp.Imagem;
                    if (File.Exists(destinoCompleto))
                    {
                        pictureImagem.ImageLocation = destinoCompleto;
                    }
                }
            }
        }

        private void btnAddFoto_Click(object sender, EventArgs e)
        {
            try
            {
                string origemCompleto = "";
                string foto = "";
                string pastaDestino = "D:\\Meus Projetos\\OrcamentoFacil\\OrcamentoFacil\\foto\\";
                destinoCompleto = "";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    origemCompleto = openFileDialog.FileName;
                    foto = openFileDialog.SafeFileName;
                    destinoCompleto = pastaDestino + foto;
                }

                if (File.Exists(destinoCompleto))
                {
                    if (MessageBox.Show("Arquivo já existe, deseja substituir?", "Substituir?", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        return;
                    }

                }
                File.Copy(origemCompleto, destinoCompleto, true);
                if (File.Exists(destinoCompleto))
                {
                    pictureImagem.ImageLocation = destinoCompleto;
                }
                else
                {
                    MessageBox.Show("Arquivo não copiado!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Falha ao carregar imagem");
            }
            
        }

        private void frmEmpresa_Load(object sender, EventArgs e)
        {
            PopulaCampos();
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            ExibeOcultaBotoes();
        }
    }
}
