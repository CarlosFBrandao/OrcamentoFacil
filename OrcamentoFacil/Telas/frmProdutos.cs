using System;
using System.Threading;
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
        public void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormShow(new frmTabProduto(Owner));
            Owner.SetFrmAtivo(frmAtivo);
        }

        private void unidadeDeMedidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormShow(new frmTabUnidadeMedida(Owner));
            Owner.SetFrmAtivo(frmAtivo);
        }
    }
}
