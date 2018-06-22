using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidad;
using Negocio;
using System.Security.Cryptography;
namespace Presentacion
{
    public partial class AgregarUsuario : System.Web.UI.Page
    {
        MD5 md5 = MD5.Create();
        ManejadorUsuarios usuarios = new ManejadorUsuarios();
        Validacion validacion = new Validacion();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Agregar_Click(object sender, EventArgs e)
        {
          
            if (validacion.validarContra(contrasena.Text, TextBox7.Text) == true)
            {
                //usuarios.agregarUsuario(Convert.ToInt32(tipo_Usuario.Text), validacion.GetMd5Hash(md5, contrasena.Text), Nombre_Usuario.Text, telefono_.Text, Direccion_.Text, Convert.ToBoolean(DropDownList1.Text));
            }
        }
    }
}