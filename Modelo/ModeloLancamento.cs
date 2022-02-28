using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    class ModeloLancamento
    {
        public int IdMovimento { get; set; }
        public ModeloEmpresa Empresa { get; set; }
        public List<ModeloProduto> Produtos{ get; set; }
        public ModeloCliente Cliente { get; set; }
    }
}
