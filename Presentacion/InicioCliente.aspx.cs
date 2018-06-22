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
    public partial class InicioCliente : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {
            Usuario usuarioActivo= (Usuario)Session["usuario"];
            lb_nombreUsuario.Text= usuarioActivo.NombreUsusario;

            List<Plato> list = new PlatoNegocio().ListarPlato();
            GridView1.DataSource = list;
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //  GridView1.SelectRow(1);
            //int pr= Convert.ToInt32(GridView1.ToString());
           

        }

        void j() {
            
        }

    }
}