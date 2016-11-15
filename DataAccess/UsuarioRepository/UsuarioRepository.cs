using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataAccess.UsuarioRepository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public List<Usuario> GetAllUsuarios()
        {
            IncidenciasDBEntities IncidenciaModel = new IncidenciasDBEntities();
            List<Usuario> usuarios = (from c in IncidenciaModel.Usuario
                                      //where c.IdTipoUsuario.Equals(2)
                                      select c).ToList();
            return usuarios;
        }

        public Usuario getUsuarioPorContrasena(Usuario registro)
        {
            using (var bd = new IncidenciasDBEntities())
            {   
                return bd.Usuario.FirstOrDefault(u => u.Codigo == registro.Codigo && u.Password == registro.Password);
            }

        }

        public Usuario getRolUsuario(Usuario objUsuario) { 
        
            using (var bd = new IncidenciasDBEntities())
            {
                var rol = from c in bd.Usuario
                             where c.IdTipoUsuario.Equals(1)
                             select c;
                return rol.FirstOrDefault();

               
                              
            }

        }


        public Usuario GetUsuarioById(int Id)
        {
            using (var model = new IncidenciasDBEntities())
            {
                var course = from c in model.Usuario
                             where c.Id == Id
                             select c;
                return course.FirstOrDefault();
            }
        
        }
           public void CambiarCredencia(Usuario objUsuario)
           {
               using (var model = new IncidenciasDBEntities())
            {
                var original = model.Usuario.Find(objUsuario.Id);

                if (original != null)
                {
                    model.Entry(original).CurrentValues.SetValues(objUsuario);
                    model.SaveChanges();
                }
            }

           }
        }

        


        
    
}
