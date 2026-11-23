using Aplicacion_Parqueadero.entidades;
using Aplicacion_Parqueadero.interfaces;
using Microsoft.EntityFrameworkCore;


namespace Aplicacion_Parqueadero.implementaciones
{
    public class NivelesAplicacion : INivelesAplicacion
    {
        private IConexion conexion;

        public NivelesAplicacion(IConexion conexion)
        {
            this.conexion = conexion;
        }

        public Niveles Actualizar(Niveles entidad)
        {
            if (entidad.Id_nivel == 0)
                throw new Exception("No se ha guardo");

            if (Validar(entidad))
                throw new Exception("Falta informacion");

            var entry = this.conexion!.Entry<Niveles>(entidad);
            entry.State = EntityState.Modified;
            this.conexion!.SaveChanges();
            return entidad;
        }

        public Niveles Borrar(Niveles entidad)
        {
            if (entidad.Id_nivel == 0)
                throw new Exception("No se ha guardo");

            this.conexion.Niveles!.Remove(entidad!);
            this.conexion.SaveChanges();
            return entidad;
        }

        public List<Niveles> Buscar(Niveles entidad)
        {
            return this.conexion.Niveles!
                .Where(x => x.Nombre!.Contains(entidad.Nombre!))
                .ToList();
                

        }

        public List<Niveles> Consultar()
        {
            return this.conexion.Niveles!.ToList();
        }

        public Niveles Insertar(Niveles entidad)
        {
            if (entidad.Id_nivel != 0)
                throw new Exception("Ya se guardo");

            if (Validar(entidad))
                throw new Exception("Falta informacion");

            this.conexion.Niveles!.Add(entidad!);
            this.conexion.SaveChanges();
            return entidad;
        }

        private bool Validar(Niveles entidad)
        {
            return string.IsNullOrEmpty(entidad.Nombre) ||
                string.IsNullOrEmpty(entidad.Ubicacion) ||
                entidad.Numero == 0 ||
                entidad.Capacidad == 0  ||
                entidad.Id_nivel == 0
                ;
        }
    }
}
