﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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