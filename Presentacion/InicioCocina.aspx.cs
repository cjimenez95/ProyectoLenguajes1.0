using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion
{
    public partial class InicioCocina : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void colorOrden()
        {
            for (int i = 0; i < GridCocina.Rows.Count; i++)
            {
                String valor = GridCocina.Rows[i].Cells[2].Text;
            }
        }
    }
}