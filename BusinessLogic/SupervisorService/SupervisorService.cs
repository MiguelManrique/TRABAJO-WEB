using DataAccess.SupervisorRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.SupervisorService
{
    public class SupervisorService : ISupervisorService
    {
        public List<Entities.Usuario> GetAllSupervisores()
        {
            ISupervisorRepository repository = new SupervisorRepository();
            return repository.GetAllSupervisores();
        }
    }
}
