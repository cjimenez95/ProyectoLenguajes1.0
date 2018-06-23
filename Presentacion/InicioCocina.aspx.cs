using System;
using Negocio;
using System.Web.UI.WebControls;

namespace Presentacion
{
    public partial class InicioCocina : System.Web.UI.Page
    {
        private CocinaNegocio cocina = new CocinaNegocio();
        protected void Page_Load(object sender, EventArgs e)
        {
            cargarOrden();
        }
        private void cargarOrden()
        {
            GridCocina.DataSource = cocina.orden();
            GridCocina.DataBind();
        }
        private void colorOrden()
        {
            for (int i = 0; i < GridCocina.Rows.Count; i++)
            {
                String valor = GridCocina.Rows[i].Cells[2].Text;
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
    }
}