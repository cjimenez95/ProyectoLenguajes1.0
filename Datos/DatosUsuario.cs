using System;
using System.Collections.Generic;
using System.Linq;
using Entidad;

namespace Datos
{
    public class DatosUsuario
    {
        db_LenguajesProyecto db = new db_LenguajesProyecto();


        public List<Usuario> ListarUsuarioss()
        {
            return db.Usuario.ToList(); ;

        }
        public Boolean AgregarUsuario(Usuario usuario)
        {
            db.Usuario.Add(usuario);
            db.SaveChanges();
            return true;
        }

        public Usuario BuscarUsuario(int id)
        {
            return db.Usuario.Find(id);

        }

       

        public Boolean EliminarUsuario(int id)
        {
            db.Usuario.Remove(BuscarUsuario( id));
            db.SaveChanges();
            return true;
        }

        public Boolean ModificarUsuario(Usuario newUser, int id)
        {
            Usuario usuario = BuscarUsuario(id);

            usuario.TipoUsuarioID = newUser.TipoUsuarioID;
            usuario.Contraseña = newUser.Contraseña;
            usuario.NombreUsusario = newUser.NombreUsusario;
            usuario.HabilitadoS_N = usuario.HabilitadoS_N;

            db.SaveChanges();

            return true;
        }
    }
}
