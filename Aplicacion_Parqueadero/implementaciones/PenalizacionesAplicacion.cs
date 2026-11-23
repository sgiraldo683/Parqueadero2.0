using Aplicacion_Parqueadero.entidades;
using Aplicacion_Parqueadero.interfaces;
using Microsoft.EntityFrameworkCore;


namespace Aplicacion_Parqueadero.implementaciones
{
    public class PenalizacionesAplicacion : IPenalizacionesAplicacion
    {
        private IConexion conexion;

        public PenalizacionesAplicacion(IConexion conexion)
        {
            this.conexion = conexion;
        }

        public Penalizaciones Actualizar(Penalizaciones entidad)
        {
            if (entidad.Id_penalizacion == 0)
                throw new Exception("No se ha guardo");

            if (Validar(entidad))
                throw new Exception("Falta informacion");

            var entry = this.conexion!.Entry<Penalizaciones>(entidad);
            entry.State = EntityState.Modified;
            this.conexion!.SaveChanges();
            return entidad;
        }

        public Penalizaciones Borrar(Penalizaciones entidad)
        {
            if (entidad.Id_penalizacion == 0)
                throw new Exception("No se ha guardo");

            this.conexion.Penalizaciones!.Remove(entidad!);
            this.conexion.SaveChanges();
            return entidad;
        }

        public List<Penalizaciones> Buscar(Penalizaciones entidad)
        {
            return this.conexion.Penalizaciones!
                .Where(x => x.Id_penalizacion.ToString() == entidad.Id_penalizacion.ToString())
                .ToList();
        }

        public List<Penalizaciones> Consultar()
        {
            return this.conexion.Penalizaciones!.ToList();
        }

        public Penalizaciones Insertar(Penalizaciones entidad)
        {
            if (entidad.Id_penalizacion != 0)
                throw new Exception("Ya se guardo");

            if (Validar(entidad))
                throw new Exception("Falta informacion");

            this.conexion.Penalizaciones!.Add(entidad!);
            this.conexion.SaveChanges();
            return entidad;
        }

        private bool Validar(Penalizaciones entidad)
        {
            return string.IsNullOrEmpty(entidad.Motivo) ||
                entidad.Id_penalizacion == 0 ||
                entidad.Id_ticket == 0 ||
                entidad.Fecha == DateTime.MinValue ||
                entidad.Valor == 0;
        }
    }
}
