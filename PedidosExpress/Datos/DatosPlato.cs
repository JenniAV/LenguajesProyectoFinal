using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Entidad;

namespace Datos
{
    public class DatosPlato
    {
        BDLenguajesProyectoEntities BDLenguajesProyectoEntities = new BDLenguajesProyectoEntities();

        public List<Plato> ListarPlatos()
        { 
                return BDLenguajesProyectoEntities.Plato.ToList(); ;
            
        }
        public Boolean AgregarPlato(Plato plato)
        {
            //BDLenguajesProyectoEntities.InsertarPalto(plato.Descripcion,plato.Precio,plato.Disponible,
               //plato.Nombre,plato.Fotografia);

            BDLenguajesProyectoEntities.Plato.Add(plato);
            BDLenguajesProyectoEntities.SaveChanges();
            return true;
        }

        public String BuscarPlatoPorNombre(String nombre)

        {
           String Platos = BDLenguajesProyectoEntities.Database.ExecuteSqlCommand(
           "exec Buscar @Nombre", new SqlParameter("@Nombre", nombre)).ToString();
            return Platos;

        }

     

        public Plato BuscarPlatoPorFecha(DateTime date)
        {
            return BDLenguajesProyectoEntities.Plato.Find(date);

        }

        //public Boolean EliminarPlato(int id)
        //{
        //    BDLenguajesProyectoEntities.Plato.Remove(BuscarPlatoPorID(id));
        //    BDLenguajesProyectoEntities.SaveChanges();
        //    return true;
        //}

        //public Boolean ModificarPlato(Plato newPlato, int id)
        //{
        //    Plato plato = BuscarPlatoPorID(id);
        //    plato.Descripcion = newPlato.Descripcion;
        //    plato.Precio = newPlato.Precio;
        //    plato.Fotografia = newPlato.Fotografia;
        //    plato.DisponibleS_N = newPlato.DisponibleS_N;

        //    BDLenguajesProyectoEntities.SaveChanges();

        //    return true;
        //}

    }


}