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
            string diretorio = AppDomain.CurrentDomain.BaseDirectory;
            conexao = new SQLiteConnection($@"Data Source={diretorio}BD\OrcamentoBD.db");
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
        public static int InsereDados(StringBuilder sb, string coluna, string tabela)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = Funcoes.ConexaoBd.ConexaoBD().CreateCommand())
                {
                    da = new SQLiteDataAdapter(sb.ToString(), ConexaoBD());
                    da.Fill(dt);
                }

                sb.Clear();
                sb.Append($"select MAX({coluna}) ID from {tabela}");

                using (var cmd = Funcoes.ConexaoBd.ConexaoBD().CreateCommand())
                {
                    da = new SQLiteDataAdapter(sb.ToString(), ConexaoBD());
                    da.Fill(dt);
                }

                return Convert.ToInt32(dt.Rows[0]["ID"]);
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
