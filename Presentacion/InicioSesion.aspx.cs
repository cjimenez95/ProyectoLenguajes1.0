using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Entidad;


namespace Presentacion
{
    public partial class InicioSesion : System.Web.UI.Page
    {

        UsuarioNegocio negocio = new UsuarioNegocio(); 
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {

        }

        protected void TextBox2_SendingMail(object sender, MailMessageEventArgs e)
        {

        }

        protected void txt_contrasena_TextChanged(object sender, EventArgs e)
        {

        }

        protected void bt_ingresar_Click(object sender, EventArgs e)
        {
            int id;
            int.TryParse(txt_codigoUsuario.Text,out id);

            Usuario usuario=negocio.inicioSesion(id,txt_contrasena.Text);
            if (usuario != null)
            {
                Session["usuario"] = usuario;

                switch (usuario.TipoUsuarioID)
                {
                    case 1:
                        Response.Redirect("InicioAdmin.aspx");
                        break;

                    case 2:
                        Response.Redirect(".aspx");
                        break;

                    case 3:
                        Response.Redirect("InicioCliente.aspx");
                        break;

                    case 4:
                        Response.Redirect(".aspx");
                        break;

                    default:
                        break;
                }
            }
            else {
                string script = "alert('Datos incorrectos');";

                ScriptManager.RegisterStartupScript(this, typeof(Page), "Error", script, true);
            }

        }
    }
}