using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.UsuarioRepository;
using Entities;

namespace BusinessLogic.UsuarioService
{
    public class UsuarioService : IUsuarioService
    {
        public List<Entities.Usuario> GetAllUsuarios()
        {
            IUsuarioRepository repository = new UsuarioRepository();
            return repository.GetAllUsuarios();
        }

        public Entities.Usuario getUsuarioPorContrasena(Usuario usuario) {
            IUsuarioRepository repository = new UsuarioRepository();
            return repository.getUsuarioPorContrasena(usuario);
        }

        public Entities.Usuario getRolUsuario(Usuario objUsuario)
        {
            IUsuarioRepository repository = new UsuarioRepository();
            return repository.getRolUsuario(objUsuario);
        }

        public void CambiarCredencia(Usuario objUsuario)
        {
            IUsuarioRepository repository = new UsuarioRepository();
            repository.CambiarCredencia(objUsuario);
        }

        public Entities.Usuario GetUsuarioById(int Id)
        {
            IUsuarioRepository repository = new UsuarioRepository();
            return repository.GetUsuarioById(Id);
        }



        //public Entities.Usuario getRolUsuario(Usuario registro) {
        //    IUsuarioRepository repository = new UsuarioRepository();
        //    return repository.get(usuario);
        
        //}


    }
}
