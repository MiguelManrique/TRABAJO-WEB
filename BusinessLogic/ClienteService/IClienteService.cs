using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ClienteService
{
    public interface IClienteService
    {
        List<Cliente> GetAllClientes();
    }
}
