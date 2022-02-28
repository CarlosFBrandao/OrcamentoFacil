using System;
using System.Collections.Generic;
using Modelo;
using DAO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class EmpresaBLL
    {
        public List<ModeloEmpresa> BuscarEmpresa()

        {
            try
            {
                return new EmpresaDAO().BuscarEmpresa();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void InserirAtualizarEmpresa(ModeloEmpresa empresa)
        {
            new EmpresaDAO().SalvarEmpresa(empresa);
        }
    }
}


