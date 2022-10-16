using OrcamentoFacil.Telas;
using System;
using OrcamentoFacil.Funcoes;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace
    OrcamentoFacil
{
    public partial class frmTelaPrincipal : Form
    {
        private Form frmAtivo;
        public frmTelaPrincipal()
        {
            InitializeComponent();
        }

        private void FormShow(Form frm)
        {
            ActiveFormClose();
            frmAtivo = frm;
            frm.TopLevel = false;
            panelPrincipal.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        public void SetFrmAtivo(Form frm)
        {
            frmAtivo = frm;
        }

        private void ActiveFormClose()
        {
            if (frmAtivo != null)
            {
                frmAtivo.Close();
            }
        }

        private void ActiveButton(Button btnFormAtivo)
        {
            foreach (Control ctrl in panelMenu.Controls)
                ctrl.BackColor = Color.FromArgb(28, 28, 28);
            btnFormAtivo.BackColor = Color.FromArgb(51, 51, 55);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            FormShow(new frmHome());
            ActiveButton(btnHome);
        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {
            FormShow(new frmEmpresa(this));
            ActiveButton(btnEmpresa);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FormShow(new frmClientes(this));
            btnExcluir.Enabled = true;
            btnNovo.Enabled = true;
            ActiveButton(btnClientes);

        }

        private void BtnProdutos_Click(object sender, EventArgs e)
        {
            FormShow(new frmProdutos());
            btnNovo.Enabled = true;
            btnExcluir.Enabled = true;
            ActiveButton(BtnProdutos);
            ((frmProdutos)frmAtivo).Owner = this;
        }

        private void btnOrcamentos_Click(object sender, EventArgs e)
        {
            btnExcluir.Enabled = true;
            btnNovo.Enabled = true;
            FormShow(new frmOrcamentos());
            ActiveButton(btnOrcamentos);
        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            FormShow(new frmRelatorios());
            ActiveButton(btnRelatorios);
        }

        private void frmTelaPrincipal_Load(object sender, EventArgs e)
        {
            FormShow(new frmHome());
            ActiveButton(btnHome);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmEmpresa>().Count() > 0)
            {
                FormShow(new frmEmpresa(this));
            }
            if (((ControlAccessibleObject)frmAtivo.AccessibilityObject).Name == "frmClientes")
            {
                ((frmClientes)frmAtivo).BuscarClientes();
            }
            if (((ControlAccessibleObject)frmAtivo.AccessibilityObject).Name == "frmTabUnidadeMedida")
            {
                ((frmTabUnidadeMedida)frmAtivo).BuscarUnidades();
            }
            btnCancelar.Enabled = false;
            btnSalvar.Enabled = false;
            btnNovo.Enabled = true;
            btnExcluir.Enabled = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string retorno = "";
            if (Application.OpenForms.OfType<frmEmpresa>().Count() > 0)
            {
                retorno = SalvarEmpresa.SalvarCadastroEmpresa((frmEmpresa)frmAtivo);
                if (retorno.Equals("Salvo Com Sucesso"))
                {
                    MessageBox.Show(retorno);
                }
            }
            if (((ControlAccessibleObject)frmAtivo.AccessibilityObject).Name == "frmClientes")
            {
                ((frmClientes)frmAtivo).SalvarCliente();
            }

            if (((ControlAccessibleObject)frmAtivo.AccessibilityObject).Name == "frmTabUnidadeMedida")
            {
                ((frmTabUnidadeMedida)frmAtivo).Salvar();
            }
            btnCancelar.Enabled = false;
            btnSalvar.Enabled = false;
            btnExcluir.Enabled = true;
        }

        public void AtivaDesativaBotoes(Form tela, bool comando)
        {
            btnSalvar.Enabled = comando;
            btnCancelar.Enabled = comando;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (((ControlAccessibleObject)frmAtivo.AccessibilityObject).Name == "frmClientes")
            {
                ((frmClientes)frmAtivo).ExcluirCliente();
            }
            if (((ControlAccessibleObject)frmAtivo.AccessibilityObject).Name == "frmTabUnidadeMedida")
            {
                ((frmTabUnidadeMedida)frmAtivo).ExcluirUnidadeMedida();
            }

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            btnNovo.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = true;
            btnSalvar.Enabled = true;

            if (((ControlAccessibleObject)frmAtivo.AccessibilityObject).Name == "frmClientes")
            {
                ((frmClientes)frmAtivo).Incluir();
            }
            if (((ControlAccessibleObject)frmAtivo.AccessibilityObject).Name == "frmTabUnidadeMedida")
            {
                ((frmTabUnidadeMedida)frmAtivo).Incluir();
            }
        }
    }
}
