using Datos;
using Entidad;
using System.Collections.Generic;
using System.Linq;

namespace Negocio
{
    public class CocinaNegocio
    {
        private DatosCocina cocina = new DatosCocina();
        public List<PLATO_ORDEN_Result> platoOrden(int ordenID)
        {
            return cocina.platoOrden(ordenID);
        }
        public List<ORDEN_VISTA> orden()
        {
            return cocina.orden();
        }
    }
}
