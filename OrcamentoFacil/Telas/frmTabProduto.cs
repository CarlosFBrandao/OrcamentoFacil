using System.Windows.Forms;
using Funcoes;

namespace OrcamentoFacil.Telas
{
    public partial class frmTabProduto : Form
    {
        public frmTabProduto()
        {
            InitializeComponent();
        }

        private void txtValorProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.AceitarSomenteNumerosDouble(e, txtValorProduto);
        }
    }
}
