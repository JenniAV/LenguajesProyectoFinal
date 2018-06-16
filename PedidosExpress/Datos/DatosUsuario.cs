using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;

namespace Datos
{
    public class DatosUsuario
    {
        BDLenguajesProyectoEntities BDLenguajesProyectoEntities = new BDLenguajesProyectoEntities();

        public List<Usuario> ListarUsuarioss()
        {
            return BDLenguajesProyectoEntities.Usuario.ToList(); ;

        }
        public Boolean AgregarUsuario(Usuario usuario)
        {
            BDLenguajesProyectoEntities.Usuario.Add(usuario);
            BDLenguajesProyectoEntities.SaveChanges();
            return true;
        }

        public Usuario BuscarUsuario(int id)
        {
            return BDLenguajesProyectoEntities.Usuario.Find(id);

        }

       

        public Boolean EliminarUsuario(int id)
        {
            BDLenguajesProyectoEntities.Usuario.Remove(BuscarUsuario( id));
            BDLenguajesProyectoEntities.SaveChanges();
            return true;
        }

        public Boolean ModificarPlato(Usuario newUser, int id)
        {
            Usuario usuario = BuscarUsuario(id);

            usuario.TipoUsuarioID = newUser.TipoUsuarioID;
            usuario.Contraseña = newUser.Contraseña;
            usuario.NombreUsusario = newUser.NombreUsusario;
            usuario.HabilitadoS_N = usuario.HabilitadoS_N;

            BDLenguajesProyectoEntities.SaveChanges();

            return true;
        }
    }
}
