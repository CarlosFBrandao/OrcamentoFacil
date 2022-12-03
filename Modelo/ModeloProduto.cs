using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloProduto
    {
        public int IdProduto { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public double ValorTotal { get; set; }
        public string Sigla { get; set; }
        public ModeloUnidadeMedida UnidadeMedida { get; set; }
        public string NomeConcat { get; set; }
        public double Quantidade { get; set; }

        public ModeloProduto()
        {
            UnidadeMedida = new ModeloUnidadeMedida();
        }

        public ModeloProduto(int idProduto, string descricao, double valorProduto, double quantidade, string sigla, double valorTotal)
        {
            UnidadeMedida = new ModeloUnidadeMedida();
            UnidadeMedida.Sigla = sigla;
            IdProduto = idProduto;
            Descricao = descricao;
            Valor = valorProduto;
            ValorTotal = valorTotal;
            Quantidade = quantidade;
        }

        public ModeloProduto(int idProduto, string descricao, double valor, string sigla, ModeloUnidadeMedida unidadeMedida, string nomeConcat)
        {
            IdProduto = idProduto;
            Descricao = descricao;
            Valor = valor;
            UnidadeMedida = unidadeMedida;
            Sigla = sigla;
            NomeConcat = nomeConcat;
        }
    }
}
