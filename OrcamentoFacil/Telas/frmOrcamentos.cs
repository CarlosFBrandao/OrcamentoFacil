﻿using System;
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
    public partial class frmOrcamentos : Form
    {
        public frmOrcamentos()
        {
            InitializeComponent();
        }

        private void AceitarNumeros(KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                //troca o . pela virgula
                e.KeyChar = ',';

                //Verifica se já existe alguma vírgula na string
                if (txtValor.Text.Contains(","))
                {
                    e.Handled = true; // Caso exista, aborte 
                }
            }

            //aceita apenas números, tecla backspace.
            else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtValorProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            AceitarNumeros(e);
        }

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            AceitarNumeros(e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            AceitarNumeros(e);
        }
    }
}