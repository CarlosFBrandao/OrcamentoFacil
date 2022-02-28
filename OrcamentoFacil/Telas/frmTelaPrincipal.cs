using OrcamentoFacil.Telas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 
    Facil
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

        private void ActiveFormClose()
        {
            if(frmAtivo != null)
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
            FormShow(new frmEmpresa());
            ActiveButton(btnEmpresa);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FormShow(new frmClientes());
            ActiveButton(btnClientes);

        }

        private void BtnProdutos_Click(object sender, EventArgs e)
        {
            FormShow(new frmProdutos());
            ActiveButton(BtnProdutos);
        }

        private void btnOrcamentos_Click(object sender, EventArgs e)
        {
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
    }
}
