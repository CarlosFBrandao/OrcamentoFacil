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
    public partial class frmProdutos : Form
    {
        private Form frmAtivo;
        public frmTelaPrincipal Owner;

        public frmProdutos()
        {
            InitializeComponent();
        }
        public void FormShow(Form frm)
        {
            ActiveFormClose();
            frmAtivo = frm;
            frm.TopLevel = false;
            panelProduto.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void ActiveFormClose()
        {
            if (frmAtivo != null)
            {
                frmAtivo.Close();
            }
        }
        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormShow(new frmTabProduto());
        }

        private void unidadeDeMedidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormShow(new frmTabUnidadeMedida());
            Owner.SetFrmAtivo(frmAtivo);
        }

        private void frmProdutos_Load(object sender, EventArgs e)
        {
            FormShow(new frmTabProduto());
        }
    }
}
