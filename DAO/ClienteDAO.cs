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
        public static DataTable dt = new DataTable();
        public static StringBuilder sb = new StringBuilder();

        public static List<ModeloCliente> BuscarClientes()
        {
            ModeloCliente cliente = null;
            List<ModeloCliente> listaCliente = new List<ModeloCliente>();
            try
            {
                sb.Clear();
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

        public static void ExcluirCliente(int idCliente, int idEndereco)
        {
            try
            {
                sb.Clear();
                sb.Append($@"delete from clientes where idClientes = {idCliente};
                             delete from endereco where idendereco = {idEndereco} ");
                var resultado = ConexaoBd.ExecutaConsulta(sb);
            }
            catch (Exception)
            {

            }
        }

        public static void SalvarCliente(ModeloCliente cliente)
        {
            sb.Clear();
            int idEndereco = EnderecoDAO.SalvarEndereco(cliente.IdEndereco, cliente.Cep, cliente.Numero, cliente.Logradouro,
                    cliente.Bairro, cliente.Complemento, cliente.Cidade, cliente.Uf);
            if (cliente.IdCliente != 0)
            {
                sb.Append($@"UPDATE clientes
                               SET
                                   idEndereco = {idEndereco},
                                   nome = '{cliente.NomeCliente}',
                                   contato = '{cliente.Contato}',
                                   telefone = '{cliente.Telefone}'
                             WHERE idClientes = {cliente.IdCliente} ");
            }
            else
            {
                sb.Append($@"INSERT INTO clientes (
                         idEndereco,
                         nome,
                         contato,
                         telefone
                     )
                     VALUES (
                         {idEndereco},
                         '{cliente.NomeCliente}',
                         '{cliente.Contato}',
                         '{cliente.Telefone}'
                     ) ");
            }

            ConexaoBd.ExecutaConsulta(sb);
        }
    }
}
