using System.Collections.Generic;
using Entidad;
using Datos;
namespace Negocio
{
    public class PlatoNegocio
    {
        BDLenguajesProyectoEntities BDLenguajesProyectoEntities = new BDLenguajesProyectoEntities();

        DatosPlato datos = new DatosPlato();

        public List<Plato> ListarPlato()
        {

            return datos.ListarPlatos();
        }

        public void InsertarPlato(String descripcion, String precio, String disponible, String nombre , 
            ref byte[]fotografia  ) {

            Plato plato = new Plato();
            //plato.PlatoID = 5;
            plato.Descripcion = descripcion;
            plato.Precio = Decimal.Parse(precio);
            if (disponible.Equals("1"))
            {
                plato.Disponible = true;
            }
            else {

                plato.Disponible = false;
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
