using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ClienteRepository
{
    public interface IClienteRepository
    {
        List<Cliente> GetAllClientes();
    }
}
