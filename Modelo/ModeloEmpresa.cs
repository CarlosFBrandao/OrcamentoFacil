using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloEmpresa : ModeloEndereco
    {
        public int IdEmpresa { get; set; }
        public string NomeEmpresa { get; set; }
        public string Contato { get; set; }
        public string Telefone { get; set; }
        public string Imagem { get; set; }
    }
}
