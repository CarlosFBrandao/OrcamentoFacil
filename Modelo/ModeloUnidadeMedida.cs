using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloUnidadeMedida
    {
        public int IdUnidadeMedida { get; set; }
        public string Descricao{ get; set; }
        public string Sigla { get; set; }

        public ModeloUnidadeMedida()
        {

        }

        public ModeloUnidadeMedida(int idUnidadeMedida, string descricao, string sigla)
        {
            IdUnidadeMedida = idUnidadeMedida;
            Descricao = descricao;
            Sigla = sigla;
        }

    }

}
