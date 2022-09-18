using Funcoes;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ClienteDAO
    {
        public static List<ModeloCliente> BuscarClientes()
        {
            DataTable dt = new DataTable();
            StringBuilder sb = new StringBuilder();
            ModeloCliente cliente = null;
            List<ModeloCliente> listaCliente = new List<ModeloCliente>();
            try
            {
                sb.Append($@"select * from clientes
                             inner join endereco on clientes.idEndereco = endereco.idendereco");

                dt = ConexaoBd.ExecutaConsulta(sb);

                foreach (DataRow row in dt.Rows)
                {
                    cliente = new ModeloCliente();
                    cliente.IdCliente = row["idClientes"] == DBNull.Value ? 0 : Convert.ToInt32(row["idClientes"]);
                    cliente.NomeCliente = row["nome"] == DBNull.Value ? string.Empty : row["nome"].ToString();
                    cliente.Contato = row["contato"] == DBNull.Value ? string.Empty : row["contato"].ToString();
                    cliente.Telefone = row["telefone"] == DBNull.Value ? string.Empty : row["telefone"].ToString();
                    cliente.IdEndereco = row["idendereco"] == DBNull.Value ? 0 : Convert.ToInt32(row["idendereco"]);
                    cliente.Cep = row["cep"] == DBNull.Value ? string.Empty : row["cep"].ToString();
                    cliente.Numero = row["numero"] == DBNull.Value ? string.Empty : row["numero"].ToString();
                    cliente.Logradouro = row["logradouro"] == DBNull.Value ? string.Empty : row["logradouro"].ToString();
                    cliente.Bairro = row["bairro"] == DBNull.Value ? string.Empty : row["bairro"].ToString();
                    cliente.Complemento = row["complemento"] == DBNull.Value ? string.Empty : row["complemento"].ToString();
                    cliente.Cidade = row["cidade"] == DBNull.Value ? string.Empty : row["cidade"].ToString();
                    cliente.Uf = row["uf"] == DBNull.Value ? string.Empty : row["uf"].ToString();

                    listaCliente.Add(cliente);
                }

                return listaCliente;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
