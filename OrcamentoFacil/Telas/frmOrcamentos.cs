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

namespace OrcamentoFacil.Telas
{
    public partial class frmOrcamentos : Form
    {
        public frmOrcamentos()
        {
            InitializeComponent();
        }

        private void txtValorProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.AceitarSomenteNumerosDouble(e, txtValorProd);
        }

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.AceitarSomenteNumerosDouble(e, txtQuantidade);
        }

        private void txtDesconto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.AceitarSomenteNumerosDouble(e, txtDesconto);
        }
    }
}
