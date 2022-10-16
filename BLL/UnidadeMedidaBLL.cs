using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace BLL
{
    public class UnidadeMedidaBLL
    {
        public static int Salvar(Modelo.ModeloUnidadeMedida und)
        {
            try
            {
                return DAO.UnidadeMedidaDAO.Salvar(und);
            }
            catch
            {
                return 0;
            }
        }

        public static List<Modelo.ModeloUnidadeMedida> BuscarUnidadesMedida()
        {
            List<Modelo.ModeloUnidadeMedida> unidades = new List<Modelo.ModeloUnidadeMedida>();
            ModeloUnidadeMedida unidade;
            try
            {
                var dtUnidades = DAO.UnidadeMedidaDAO.Buscar();
                foreach (DataRow und in dtUnidades.Rows)
                {
                    unidade = new ModeloUnidadeMedida(
                        idUnidadeMedida: und["idUnidadeMedida"] == DBNull.Value ? 0 : Convert.ToInt32(und["idUnidadeMedida"]),
                        descricao: und["descricao"] == DBNull.Value ? string.Empty : und["descricao"].ToString(),
                        sigla: und["sigla"] == DBNull.Value ? string.Empty : und["sigla"].ToString()
                        );
                    unidades.Add(unidade);
                }
            }
            catch
            {
            }
            return unidades;
        }

        public static string Excluir(int idUnidadeMedida)
        {
            try
            {
                if (DAO.ProdutoDAO.UnidadeMedidaEmUso(idUnidadeMedida))
                {
                    return "Unidade de Medida em uso, não é possível Excluir";
                }
                else
                {
                    DAO.UnidadeMedidaDAO.Excluir(idUnidadeMedida);
                    return "Excluído com sucesso!";
                }
            }
            catch
            {
                return "Falha ao Excluir Registro";
            }
        }
    }
}
