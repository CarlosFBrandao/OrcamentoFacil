using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using Modelo;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ClientesBLL
    {
        public static List<ModeloCliente> BuscarClientes()
        {
            try
            {
                DataTable dtCliente = DAO.ClienteDAO.BuscarClientes();
                ModeloCliente cliente = new ModeloCliente();
                List<ModeloCliente> listaCliente = new List<ModeloCliente>();
                foreach (DataRow row in dtCliente.Rows)
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
                    cliente.NomeConcat = $"{cliente.IdCliente} - {cliente.NomeCliente}";

                    listaCliente.Add(cliente);
                }
                return listaCliente;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void ExcluirCliente(int idCliente, int idEndereco)
        {
            try
            {
                DAO.ClienteDAO.ExcluirCliente(idCliente, idEndereco);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static void SalvarCLiente(ModeloCliente cliente)
        {
            try
            {
                DAO.ClienteDAO.SalvarCliente(cliente);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
