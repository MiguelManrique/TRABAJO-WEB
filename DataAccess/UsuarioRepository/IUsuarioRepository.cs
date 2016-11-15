using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataAccess.UsuarioRepository
{
    public interface IUsuarioRepository
    {
        List<Usuario> GetAllUsuarios();
        Usuario getUsuarioPorContrasena(Usuario registro);

        Usuario getRolUsuario(Usuario objUsuario);

        void CambiarCredencia(Usuario objUsuario);

        Usuario GetUsuarioById(int Id);
    }
}
