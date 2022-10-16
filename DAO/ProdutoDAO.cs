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

        public static DataTable Buscar()
        {
            sb.Clear();
            sb.Append($@"select
                             prod.idProduto,
                             prod.idUnidadeMedida,
                             prod.descricao descricaoProduto,
                             prod.valor,
                             und.descricao descricaoUnidadeMedida,
                             und.sigla
                         from produto prod
                         inner join unidadeMedida und
                         on prod.idUnidadeMedida = und.idUnidadeMedida");

            return ConexaoBd.ExecutaConsulta(sb);
        }

        public static int Inserir(Modelo.ModeloProduto produto)
        {
            sb.Clear();
            if (produto.IdProduto > 0)
            {
                sb.Append($@"UPDATE produto
                               SET idUnidadeMedida = {produto.UnidadeMedida.IdUnidadeMedida},
                                   descricao = '{produto.Descricao}',
                                   valor = {produto.Valor}
                             WHERE idProduto = {produto.IdProduto}
                            ");
            }
            else
            {
                sb.Append($@"INSERT INTO produto (
                                                idUnidadeMedida,
                                                descricao,
                                                valor
                                            )
                                            VALUES (
                                                {produto.UnidadeMedida.IdUnidadeMedida},
                                                '{produto.Descricao}',
                                                {produto.Valor}
                                            );");
            }

            return ConexaoBd.InsereDados(sb, "idProduto", "produto");
        }

        public static void Excluir(int idProduto)
        {
            sb.Clear();
            sb.Append($"delete from produto where idProduto = {idProduto}");

            ConexaoBd.ExecutaConsulta(sb);
        }
    }
}
