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

    





    
}
}
