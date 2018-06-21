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
        public Boolean AgregarUsuario(int UsuarioID,int tipoUsuario,String contrasena,String nombreUsuario,String telefono,String direccion,Boolean habilitado)
        {
            db.insert_Usuario(UsuarioID,tipoUsuario,contrasena,nombreUsuario,telefono,direccion,habilitado);
            db.SaveChanges();
            return true;
        }

        public Usuario BuscarUsuario(int id)
        {
            return db.Usuario.Find(id);

        }

        public Boolean EliminarUsuario(int id)
        {
            db.eliminar_Usuario(id);
            db.SaveChanges();
            return true;
        }

        public Boolean ModificarUsuario(int UsuarioID, int tipoUsuario, String contrasena, String nombreUsuario, String telefono, String direccion, Boolean habilitado)
        {
            db.Modificar_Usuario(UsuarioID, tipoUsuario, contrasena, nombreUsuario, telefono, direccion, habilitado);
            db.SaveChanges();

            return true;
        }
    }
}
