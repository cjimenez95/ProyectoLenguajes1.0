using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using Datos;
using System.Security.Cryptography;

namespace Negocio
{
    public class UsuarioNegocio
    {
        DatosUsuario datos = new DatosUsuario();

        public Usuario inicioSesion(int id, string contrasena) {
            Usuario usuario= datos.BuscarUsuario(id);

            if (usuario != null)
            {
                MD5 md5 = MD5.Create();

                byte[] data = md5.ComputeHash(Encoding.UTF8.GetBytes(contrasena));

                StringBuilder sBuilder = new StringBuilder();
                for (int i = 0; i < data.Length; i++)
                {
                    sBuilder.Append(data[i].ToString("x2"));
                }
                String hashContrasena=sBuilder.ToString();
                if (hashContrasena.Equals(usuario.Contraseña))
                {
                    return usuario;
                }
                return null;
            }
            else {
                return null;
            }
            
        }
    }
}
