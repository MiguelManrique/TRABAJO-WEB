using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.RecursosRepository;
using Entities;

namespace BusinessLogic.RecursosService
{
    public class RecursosService : IRecursosService
    {
        public List<RecursoDigital> GetAllRecursos()
        {
            IRecursosRepository repository = new RecursosRepository();
            return repository.GetAllRecursos();
        }
    }
}
