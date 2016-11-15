using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using DataAccess.EstadoRepository;
using Entities;

namespace BusinessLogic.EstadoService
{
    public class EstadoService : IEstadoService
    {
        public List<Estado> GetAllEstados()
        {
            IEstadoRepository repository = new EstadoRepository();
            return repository.GetAllEstados();
        }
    }
}
