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
        public string Sigla { get; set; }
        public ModeloUnidadeMedida UnidadeMedida { get; set; }

        public ModeloProduto()
        {
            UnidadeMedida = new ModeloUnidadeMedida();
        }

        public ModeloProduto(int idProduto, string descricao, double valor, string sigla, ModeloUnidadeMedida unidadeMedida)
        {
            IdProduto = idProduto;
            Descricao = descricao;
            Valor = valor;
            UnidadeMedida = unidadeMedida;
            Sigla = sigla;
        }
    }
}
