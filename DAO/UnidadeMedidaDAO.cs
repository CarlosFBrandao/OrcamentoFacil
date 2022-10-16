using Funcoes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class UnidadeMedidaDAO
    {
        public static DataTable dt = new DataTable();
        public static StringBuilder sb = new StringBuilder();

        public static int Salvar(Modelo.ModeloUnidadeMedida und)
        {
            sb.Clear();
            if (und.IdUnidadeMedida > 0)
            {
                sb.Append($@"UPDATE unidadeMedida
                               SET descricao = '{und.Descricao}',
                                   sigla = '{und.Sigla}'
                             WHERE idUnidadeMedida = {und.IdUnidadeMedida};");
            }
            else
            {
                sb.Append($@"INSERT INTO unidadeMedida (
                              descricao,
                              sigla
                          )
                             VALUES (
                                 '{und.Descricao}',
                                 '{und.Sigla}'
                                  );");
            }

            return ConexaoBd.InsereDados(sb, "idUnidadeMedida", "unidadeMedida");
        }

        public static DataTable Buscar()
        {
            sb.Clear();
            sb.Append($@"select * from unidadeMedida");

            return ConexaoBd.ExecutaConsulta(sb);
        }

        public static void Excluir(int idUnidadeMedida)
        {
            sb.Clear();
            sb.Append($@"delete from unidadeMedida where idUnidadeMedida = {idUnidadeMedida}");

            ConexaoBd.ExecutaConsulta(sb);
        }
    }
}
