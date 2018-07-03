using System;
using Negocio;
using System.Web.UI.WebControls;
using System.Drawing;
using System.Web.Services;

namespace Presentacion
{
    public partial class InicioCocina : System.Web.UI.Page
    {
        private CocinaNegocio cocina = new CocinaNegocio();
        private int platoId;
        private static bool valorEntrega = false;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargarOrden();
            }
        }
        private void cargarOrden()
        {
            GridCocina.DataSource = cocina.orden();
            GridCocina.DataBind();
            colorOrden();
            mostrarMensaje();
        }
        private void mostrarMensaje()
        {
            if (cocina.cantidadOrdenes() > 10)
            {
                Label1.Text = "HAY MAS ORDENES EN ESPERA";
            }
            else
            {
                Label1.Text = "";
            }

        }
        private void colorOrden()
        {
            for (int i = 0; i < GridCocina.Rows.Count; i++)
            {
                String valor = GridCocina.Rows[i].Cells[2].Text;
                if (valor.Equals("A Tiempo"))
                {
                    GridCocina.Rows[i].BackColor = Color.LightGreen;
                }
                else if (valor.Equals("Sobre Tiempo"))
                {
                    GridCocina.Rows[i].BackColor = Color.LightYellow;
                }
                else if (valor.Equals("Demorado"))
                {
                    GridCocina.Rows[i].BackColor = Color.Tomato;
                }
            }
        }

        protected void GridCocina_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            GridView gridPlatos;
            GridViewRow item;
            int ordenID;
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                item = e.Row;
                ordenID = int.Parse(item.Cells[0].Text);
                gridPlatos = (GridView)e.Row.Cells[3].Controls[1];

                gridPlatos.DataSource = cocina.platoOrden(ordenID);
                gridPlatos.DataBind();
            }
        }
        [WebMethod]
        public static void obtenerValorConfirmacion(bool valor)
        {
            valorEntrega = valor;   
        }

        protected void GridCocina_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName.Equals("seleccion"))
            {
                GridViewRow row = (GridViewRow)(((Button)e.CommandSource).NamingContainer);
                platoId = Convert.ToInt32(this.GridCocina.Rows[row.RowIndex].Cells[0].Text);
                gg();
            }
        }
        public void gg()
        {
            if (valorEntrega)
            {
                cocina.actualizarEntregado(platoId);
                cargarOrden();
            }
        }

        protected void GridCocina_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            cargarOrden();
        }
    }
}