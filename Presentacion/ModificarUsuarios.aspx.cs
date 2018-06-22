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
    public partial class ModificarUsuarios : System.Web.UI.Page
    {
        MD5 md5 = MD5.Create();
        ManejadorUsuarios usuario = new ManejadorUsuarios();
        Validacion validacion = new Validacion();
        protected void Page_Load(object sender, EventArgs e)
        {

            cargarGrid();

        }
        public void cargarGrid()
        {
           // GridView1.DataSource = usuario.listaBorrar();
            GridView1.DataBind();
        }
        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            usuario.ModificarUsuario(Convert.ToInt32(UsuarioID.Text),Convert.ToInt32(TipoUsuario.Text), validacion.GetMd5Hash(md5, Contrasena.Text), Nombre.Text, Telefono.Text, Direccion.Text, Convert.ToBoolean(habilitado.Text));
        }
    }
}