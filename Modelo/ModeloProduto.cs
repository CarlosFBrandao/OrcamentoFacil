using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    class ModeloProduto
    {
        public int IdProduto { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public ModeloUnidadeMedida UnidadeMedida { get; set; }
    }
}
