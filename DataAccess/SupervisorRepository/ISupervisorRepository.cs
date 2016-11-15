using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.SupervisorRepository
{
   public interface ISupervisorRepository
    {
        List<Usuario> GetAllSupervisores();
        

       
    }
}
