using System;
using System.Collections.Generic;
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
        public frmEmpresa()
        {
            InitializeComponent();
        }

        private void btnAddFoto_Click(object sender, EventArgs e)
        {
            string origemCompleto = "";
            string foto = "";
            string pastaDestino = "foto\\";
            string destinoCompleto = "";

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                origemCompleto = openFileDialog.FileName;
                foto = openFileDialog.SafeFileName;
                destinoCompleto = pastaDestino + foto;
            }

            if (File.Exists(destinoCompleto))
            {
                if(MessageBox.Show("Arquivo já existe, deseja substituir?", "Substituir?", MessageBoxButtons.YesNo) == DialogResult.No)
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
    }
}
