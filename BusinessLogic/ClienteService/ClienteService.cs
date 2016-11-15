using DataAccess.ClienteRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ClienteService
{
    public class ClienteService : IClienteService
    {
        public List<Entities.Cliente> GetAllClientes()
        {
            IClienteRepository repository = new ClienteRepository();
            return repository.GetAllClientes();
        }
    }
}
