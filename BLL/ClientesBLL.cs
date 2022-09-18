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
    }
}
