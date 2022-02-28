using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;

namespace Funcoes
{
    public class ConexaoBd
    {
        public static SQLiteConnection conexao;

        public static SQLiteConnection ConexaoBD()
        {
            conexao = new SQLiteConnection("Data Source=D:\\Meus Projetos\\OrcamentoFacil\\OrcamentoFacil\\BD\\OrcamentoBD.db");
            conexao.Open();
            return conexao;
        }

        public static DataTable ExecutaConsulta(StringBuilder sb)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = Funcoes.ConexaoBd.ConexaoBD().CreateCommand())
                {
                    da = new SQLiteDataAdapter(sb.ToString(), ConexaoBD());
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static DataTable RetornaId(StringBuilder sb)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = Funcoes.ConexaoBd.ConexaoBD().CreateCommand())
                {
                    da = new SQLiteDataAdapter(sb.ToString(), ConexaoBD());
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
