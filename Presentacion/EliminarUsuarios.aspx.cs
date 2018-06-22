using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidad;
using Negocio;
namespace Presentacion
{
    public partial class EliminarUsuarios : System.Web.UI.Page
    {
        ManejadorUsuarios usuario = new ManejadorUsuarios();
        protected void Page_Load(object sender, EventArgs e)
        {
            cargarGrid();
        }
        public void cargarGrid()
        {
            GridView1.DataSource = usuario.listaBorrar();
            GridView1.DataBind();
        }
        protected void Eliminar_Click(object sender, EventArgs e)
        {
            usuario.eliminarUsuario(Convert.ToInt32(Usuario_ID.Text));
            cargarGrid();
        }
    }
}