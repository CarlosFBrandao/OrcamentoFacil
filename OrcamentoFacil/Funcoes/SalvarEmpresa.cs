using System;
using Modelo;
using BLL;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrcamentoFacil.Telas;
using System.Windows.Forms;

namespace OrcamentoFacil.Funcoes
{
    public class SalvarEmpresa
    {
        public static frmEmpresa FrmEmpresa;

        public static string SalvarCadastroEmpresa(frmEmpresa frm)
        {
            FrmEmpresa = frm;
            try
            {
                ModeloEmpresa empresa = new ModeloEmpresa();

                empresa.NomeEmpresa = frm.txtEmpresa.Text;
                empresa.Contato = frm.txtContato.Text;
                empresa.Telefone = frm.txtTelefone.Text;
                empresa.Imagem = frm.destinoCompleto;
                empresa.Cep = frm.txtCep.Text;
                empresa.Logradouro = frm.txtRua.Text;
                empresa.Numero = frm.txtNumero.Text;
                empresa.Complemento = frm.txtComplemento.Text;
                empresa.Bairro = frm.txtBairro.Text;
                empresa.Uf = frm.txtUf.Text;
                empresa.Cidade = frm.txtCidade.Text;

                new EmpresaBLL().InserirAtualizarEmpresa(empresa);
                
                return "Salvo Com Sucesso";
            }
            catch (Exception)
            {
                return "Favor Verificar os Campos";
            }
        }
    }
}
