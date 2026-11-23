using Aplicacion_Parqueadero.entidades;
using Aplicacion_Parqueadero.interfaces;
using Microsoft.EntityFrameworkCore;


namespace Aplicacion_Parqueadero.implementaciones
{
    public class PlanesAplicacion : IPlanesAplicacion
    {
        private IConexion conexion;

        public PlanesAplicacion (IConexion conexion)
        {
            this.conexion = conexion;
        }

        public Planes Actualizar(Planes entidad)
        {
            if (entidad.Id_plan == 0)
                throw new Exception("No se ha guardo");

            if (Validar(entidad))
                throw new Exception("Falta informacion");

            var entry = this.conexion!.Entry<Planes>(entidad);
            entry.State = EntityState.Modified;
            this.conexion!.SaveChanges();
            return entidad;
        }

        public Planes Borrar(Planes entidad)
        {
            if (entidad.Id_plan == 0)
                throw new Exception("No se ha guardo");

            this.conexion.Planes!.Remove(entidad!);
            this.conexion.SaveChanges();
            return entidad;
        }

        public List<Planes> Buscar(Planes entidad)
        {
            return this.conexion.Planes!
                .Where(x => x.Nombre!.Contains(entidad.Nombre!))
                .ToList();
        }

        public List<Planes> Consultar()
        {
            return this.conexion.Planes!.ToList();
        }

        public Planes Insertar(Planes entidad)
        {
            if (entidad.Id_plan != 0)
                throw new Exception("Ya se guardo");

            if (Validar(entidad))
                throw new Exception("Falta informacion");

            this.conexion.Planes!.Add(entidad!);
            this.conexion.SaveChanges();
            return entidad;
        }

        private bool Validar(Planes entidad)
        {
            return string.IsNullOrEmpty(entidad.Nombre) ||
                entidad.Precio == 0 ||
                entidad.Duracion_dias == 0 ||
               string.IsNullOrEmpty(entidad.Descripcion) ||
               entidad.Id_plan == 0;
        }
    }
}
