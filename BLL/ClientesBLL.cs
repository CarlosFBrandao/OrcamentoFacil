using Modelo;
using System;
using System.Collections.Generic;
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
                return DAO.ClienteDAO.BuscarClientes();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void ExcluirCliente(int idCliente)
        {
            try
            {
                DAO.ClienteDAO.ExcluirCliente(idCliente);
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
