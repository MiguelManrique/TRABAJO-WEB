using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace DataAccess.SupervisorRepository
{
    public class SupervisorRepository : ISupervisorRepository
    {
        public List<Usuario> GetAllSupervisores()
        {
            IncidenciasDBEntities IncidenciaModel = new IncidenciasDBEntities();
            List<Usuario> usuarios = (from c in IncidenciaModel.Usuario
                                      where c.IdTipoUsuario.Equals(2)
                                      select c).ToList();
            return usuarios;
        }

       

       
    }
}
