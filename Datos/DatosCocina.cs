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
        public void actualizarEntregado(int pedidoID)
        {
            db.ACTUALIZAR_ESTADO(pedidoID);
        }
        public int cantidadOrdenes()
        {
            return db.CANTIDAD_ORDENES.ToList().Count;
        }
    }
}
