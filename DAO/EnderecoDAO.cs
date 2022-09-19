using Funcoes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class EnderecoDAO
    {
        public static DataTable dt = new DataTable();
        public static StringBuilder sb = new StringBuilder();

        public static int SalvarEndereco(int idEndereco, string cep, string numero, string logradouro,
            string bairro, string complemento, string cidade, string uf)
        {
            sb.Clear();
            if (idEndereco == 0)
            {
                sb.Append($@"INSERT INTO endereco(
                         cep,
                         numero,
                         logradouro,
                         bairro,
                         complemento,
                         cidade,
                         uf
                     )
                     VALUES(
                         '{cep}',
                         '{numero}',
                         '{logradouro}',
                         '{bairro}',
                         '{complemento}',
                         '{cidade}',
                         '{uf}'
                     ) ");
            }

            else
            {
                sb.Append($@"UPDATE endereco
                             SET
                                 cep = '{cep}',
                                 numero = '{numero}',
                                 logradouro = '{logradouro}',
                                 bairro = '{bairro}',
                                 complemento = '{complemento}',
                                 cidade = '{cidade}',
                                 uf = '{uf}'
                           WHERE idendereco = {idEndereco}
                           ");
            }

            return ConexaoBd.InsereDados(sb, "idEndereco", "endereco");
        }
    }
}
