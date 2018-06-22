using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidad;

namespace Negocio
{
    public class ManejadorUsuarios
    {

         DatosUsuario datos = new DatosUsuario();

        //public bool agregarUsuario( int tipoUsuario, String contrasena, String nombreUsuario, String telefono, String direccion, Boolean habilitado) {

        //    return datos.AgregarUsuario(tipoUsuario, contrasena, nombreUsuario, telefono, direccion, habilitado);
        //}

        public Boolean ModificarUsuario(int UsuarioID, int tipoUsuario, String contrasena, String nombreUsuario, String telefono, String direccion, Boolean habilitado)
        {
            return datos.ModificarUsuario(UsuarioID,tipoUsuario, contrasena, nombreUsuario, telefono, direccion, habilitado);
        }
        public List<Usuario> mostrarUsuarios() {

            return datos.getUsuarios();
        }
        //public List<Vista_Clientes> listaBorrar() {
        //    return datos.ListaUsuarioss();
        //}

        public bool eliminarUsuario(int id) {

           return datos.EliminarUsuario(id);

        }
    }
}
