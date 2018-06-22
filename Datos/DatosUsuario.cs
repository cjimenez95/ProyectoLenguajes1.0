using System;
using System.Collections.Generic;
using System.Linq;
using Entidad;

namespace Datos
{
    public class DatosUsuario
    {
        dbLenguajesProyectoEntities db = new dbLenguajesProyectoEntities();


        //public List<Vista_Clientes> ListaUsuarioss()
        //{
        //    return db.Vista_Clientes.ToList();
        //}
        //public Boolean AgregarUsuario(int tipoUsuario,String contrasena,String nombreUsuario,String telefono,String direccion,Boolean habilitado)
        //{
        //    db.insert_Usuario(tipoUsuario,contrasena,nombreUsuario,telefono,direccion,habilitado);
        //    db.SaveChanges();
        //    return true;
        //}

        public List<Usuario> getUsuarios() {

            return db.Usuario.ToList();
        }

        public Usuario BuscarUsuario(int id)
        {
            return db.Usuario.Find(id);

        }

        public Boolean EliminarUsuario(int id)
        {
            //db.eliminar_Usuario(id);
            db.SaveChanges();
            return true;
        }

        public Boolean ModificarUsuario(int UsuarioID, int tipoUsuario, String contrasena, String nombreUsuario, String telefono, String direccion, Boolean habilitado)
        {
           // db.Modificar_Usuario(UsuarioID, tipoUsuario, contrasena, nombreUsuario, telefono, direccion, habilitado);
            db.SaveChanges();

            return true;
        }
    }
}
