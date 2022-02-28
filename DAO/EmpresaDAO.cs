using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using Funcoes;
using Modelo;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class EmpresaDAO
    {
        public List<ModeloEmpresa> BuscarEmpresa()
        {
            DataTable dt = new DataTable();
            StringBuilder sb = new StringBuilder();
            ModeloEmpresa empresa = null;
            List<ModeloEmpresa> listaEmpresa = new List<ModeloEmpresa>();
            try
            {
                sb.Append("select * from empresa join endereco ")
                     .Append("on empresa.idendereco = endereco.idendereco");

                dt = ConexaoBd.ExecutaConsulta(sb);

                foreach (DataRow row in dt.Rows)
                {
                    empresa = new ModeloEmpresa();
                    if (row["idempresa"] != DBNull.Value)
                        empresa.IdEmpresa = Convert.ToInt32(row["idempresa"]);
                    if (row["idendereco"] != DBNull.Value)
                        empresa.IdEndereco = Convert.ToInt32(row["idendereco"]);
                    if (row["nome"] != DBNull.Value)
                        empresa.NomeEmpresa = row["nome"].ToString();
                    if (row["contato"] != DBNull.Value)
                        empresa.Contato = row["contato"].ToString();
                    if (row["telefone"] != DBNull.Value)
                        empresa.Telefone = row["telefone"].ToString();
                    if (row["imagem"] != DBNull.Value)
                        empresa.Imagem = row["imagem"].ToString();
                    if (row["cep"] != DBNull.Value)
                        empresa.Cep = row["cep"].ToString();
                    if (row["numero"] != DBNull.Value)
                        empresa.Numero = row["numero"].ToString();
                    if (row["logradouro"] != DBNull.Value)
                        empresa.Logradouro = row["logradouro"].ToString();
                    if (row["bairro"] != DBNull.Value)
                        empresa.Bairro = row["bairro"].ToString();
                    if (row["complemento"] != DBNull.Value)
                        empresa.Complemento = row["complemento"].ToString();
                    if (row["cidade"] != DBNull.Value)
                        empresa.Cidade = row["cidade"].ToString();
                    if (row["uf"] != DBNull.Value)
                        empresa.Uf = row["uf"].ToString();
                    listaEmpresa.Add(empresa);
                }

                return listaEmpresa;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static DataTable VerificarEmpresa()
        {
            DataTable dt = new DataTable();
            StringBuilder sb = new StringBuilder();
            try
            {
                sb.Append($"select idempresa, idendereco from empresa");
                dt = ConexaoBd.ExecutaConsulta(sb);

                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void SalvarEmpresa(ModeloEmpresa empresa)
        {
            try
            {
                int idEmpresa = 0;
                int idEndereco = 0;
                StringBuilder sb = new StringBuilder();
                DataTable dt = VerificarEmpresa();

                foreach (DataRow row in dt.Rows)
                {
                    if (row["idempresa"] != DBNull.Value)
                        idEmpresa = Convert.ToInt32(row["idempresa"]);
                    if (row["idendereco"] != DBNull.Value)
                        idEndereco = Convert.ToInt32(row["idendereco"]);
                }
                if (idEmpresa != 0)
                {
                    sb.Append("UPDATE endereco ")
                        .Append($"SET cep = '{empresa.Cep}', ")
                        .Append($"numero = '{empresa.Numero}', ")
                        .Append($"logradouro = '{empresa.Logradouro}', ")
                        .Append($"bairro = '{empresa.Bairro}', ")
                        .Append($"complemento = '{empresa.Complemento}', ")
                        .Append($"cidade = '{empresa.Cidade}', ")
                        .Append($"uf = '{empresa.Uf}' ")
                        .Append($"WHERE idendereco = {idEndereco}");
                    ConexaoBd.ExecutaConsulta(sb);

                    sb.Clear();
                    sb.Append("UPDATE empresa ")
                        .Append($"SET idendereco = {idEndereco}, ")
                        .Append($"nome = '{empresa.NomeEmpresa}', ")
                        .Append($"contato = '{empresa.Contato}', ")
                        .Append($"telefone = '{empresa.Telefone}', ")
                        .Append($"imagem = '{empresa.Imagem}' ")
                        .Append($"WHERE idempresa = {idEmpresa}");
                    ConexaoBd.ExecutaConsulta(sb);
                }

                else
                {
                    sb.Append("INSERT INTO endereco (cep, numero, logradouro, bairro, complemento, cidade, uf) ")
                        .Append($"VALUES({empresa.Cep},{empresa.Numero},{empresa.Logradouro},{empresa.Bairro},{empresa.Complemento}, {empresa.Cidade}");
                    ConexaoBd.ExecutaConsulta(sb);
                    sb.Clear();
                    //Retorna o IDInserido
                    sb.Append("select Max(idendereco) as idendereco from endereco");
                    dt = ConexaoBd.ExecutaConsulta(sb);
                    foreach (DataRow row in dt.Rows)
                    {
                        if (row["idendereco"] != DBNull.Value)
                            empresa.IdEndereco = Convert.ToInt32(row["idendereco"]);
                    }

                    sb.Append("INSERT INTO empresa (idendereco, nome, contato, telefone, imagem) ")
                        .Append($"VALUES({empresa.IdEndereco},{empresa.NomeEmpresa},{empresa.Contato},{empresa.Telefone},{empresa.Imagem}");
                }

            }

            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
