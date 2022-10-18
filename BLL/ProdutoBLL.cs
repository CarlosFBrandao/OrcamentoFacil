using System;
using System.Collections.Generic;
using System.Data;
using Modelo;

namespace BLL
{
    public class ProdutoBLL
    {
        public static List<ModeloProduto> Buscar()
        {
            List<ModeloProduto> produtos = new List<ModeloProduto>();
            ModeloProduto produto;
            DataTable dtProdutos = DAO.ProdutoDAO.Buscar();
            try
            {
                foreach (DataRow prod in dtProdutos.Rows)
                {
                    produto = new ModeloProduto(
                        idProduto: prod["idProduto"] == DBNull.Value ? 0 : Convert.ToInt32(prod["idProduto"]),
                        descricao: prod["descricaoProduto"] == DBNull.Value ? string.Empty : prod["descricaoProduto"].ToString(),
                        valor: prod["valor"] == DBNull.Value ? 0 : Convert.ToDouble(prod["valor"]),
                        sigla: prod["sigla"] == DBNull.Value ? string.Empty : prod["sigla"].ToString(),
                        new ModeloUnidadeMedida(
                            idUnidadeMedida: prod["idUnidadeMedida"] == DBNull.Value ? 0 : Convert.ToInt32(prod["idUnidadeMedida"]),
                            descricao: prod["descricaoUnidadeMedida"] == DBNull.Value ? string.Empty : prod["descricaoUnidadeMedida"].ToString(),
                            sigla: prod["sigla"] == DBNull.Value ? string.Empty : prod["sigla"].ToString()),
                        nomeConcat: $"{prod["idProduto"]} - {prod["descricaoProduto"]} ({prod["sigla"]})"
                        );

                    produtos.Add(produto);
                }

            }
            catch { }
            return produtos;
        }

        public static int Inserir(ModeloProduto produto)
        {
            int idProduto = 0;
            try
            {
                idProduto = DAO.ProdutoDAO.Inserir(produto);
            }
            catch { }
            return idProduto;
        }

        public static string Excluir(int idProduto)
        {
            try
            {
                DAO.ProdutoDAO.Excluir(idProduto);
            }
            catch
            {
            }
            return string.Empty;
        }
    }
}
