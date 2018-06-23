using System.Collections.Generic;
using System.Linq;
using Entidad;

namespace Datos
{
    public class DatosCocina
    {
        private dbLenguajesProyectoEntities db = new dbLenguajesProyectoEntities();
        public List<PLATO_ORDEN_Result> platoOrden(int ordenID)
        {
            return db.PLATO_ORDEN(ordenID).ToList();
        }
        public List<ORDEN_VISTA> orden()
        {
            return db.ORDEN_VISTA.ToList();
        }
    }
}
