using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloListaProdutos
    {
        public int IdProduto { get; set; }
        public string  Descricao { get; set; }
        public string  UnidadeMedida { get; set; }
        public double Quantidade { get; set; }
        public double Valor { get; set; }
        public double  ValorTotal { get; set; }

        public ModeloListaProdutos() { }

        public ModeloListaProdutos(int idProduto, string descricao, string unidadeMedida, double quantidade, double valor, double valorTotal)
        {
            IdProduto = idProduto;
            Descricao = descricao;
            UnidadeMedida = unidadeMedida;
            Quantidade = quantidade;
            Valor = valor;
            ValorTotal = valorTotal;
        }
    }
}
