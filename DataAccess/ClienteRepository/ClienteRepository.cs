using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ClienteRepository
{
    public class ClienteRepository : IClienteRepository
    {
        public List<Entities.Cliente> GetAllClientes()
        {
            IncidenciasDBEntities IncidenciasBDModel = new IncidenciasDBEntities();
            List<Cliente> cliente = (from c in IncidenciasBDModel.Cliente
                                   //where c.Name.Contains("ing")
                                   select c).ToList();
            return cliente;
        }
    }
}
