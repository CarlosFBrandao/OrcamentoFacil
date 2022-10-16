using Funcoes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ProdutoDAO
    {

        public static DataTable dt = new DataTable();
        public static StringBuilder sb = new StringBuilder();

        public static bool UnidadeMedidaEmUso(int idUnidadeMedida)
        {
            sb.Clear();
            sb.Append($@"select * from produto where idUnidadeMedida = {idUnidadeMedida}");

            var retorno = ConexaoBd.ExecutaConsulta(sb);
            return retorno.Rows.Count > 0 ? true : false;
        }
    }
}
