using System.Collections.Generic;
using Entidad;
using Datos;
namespace Negocio
{
    public class PlatoNegocio
    {
        DatosPlato datos = new DatosPlato();

        public List<Plato> ListarPlato()
        {

            return datos.ListarPlatos();
        }

        public void InsertarPlato(string descripcion, string precio, string disponible, string nombre , 
            ref byte[]fotografia  ) {

            Plato plato = new Plato();
            //plato.PlatoID = 5;
            plato.Descripcion = descripcion;
            plato.Precio = decimal.Parse(precio);
            if (disponible.Equals("1"))
            {
                plato.DisponibleS_N = true;
            }
            else {

                plato.DisponibleS_N = false;
            }
            plato.Nombre = nombre;
            plato.Fotografia = fotografia;

            datos.AgregarPlato(plato);
        }
        //public List<String> Buscar(String id)
        //{
        //    List<String> platos = new List<String>();
        //    platos.Add(datos.BuscarPlatoPorNombre(id));
        //    return platos;
        //}








    }
}
