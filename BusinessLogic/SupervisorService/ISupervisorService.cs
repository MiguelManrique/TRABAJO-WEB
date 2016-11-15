using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.SupervisorService
{
    public interface ISupervisorService
    {
        List<Usuario> GetAllSupervisores();
        
    }
}
