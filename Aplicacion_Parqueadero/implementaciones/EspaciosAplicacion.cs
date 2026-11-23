using Aplicacion_Parqueadero.entidades;
using Aplicacion_Parqueadero.interfaces;
using Microsoft.EntityFrameworkCore;


namespace Aplicacion_Parqueadero.implementaciones
{
    public class EspaciosAplicacion : IEspaciosAplicacion
    {
        private IConexion conexion;

        public EspaciosAplicacion(IConexion conexion)
        {
            this.conexion = conexion;
        }

        public Espacios Actualizar(Espacios entidad)
        {
            if (entidad.Id_espacio == 0)
                throw new Exception("No se ha guardo");

            if (Validar(entidad))
                throw new Exception("Falta informacion");

            var entry = this.conexion!.Entry<Espacios>(entidad);
            entry.State = EntityState.Modified;
            this.conexion!.SaveChanges();
            return entidad;
        }

        public Espacios Borrar(Espacios entidad)
        {
            if (entidad.Id_espacio == 0)
                throw new Exception("No se ha guardo");

            this.conexion.Espacios!.Remove(entidad!);
            this.conexion.SaveChanges();
            return entidad;
        }

        public List<Espacios> Buscar(Espacios entidad)
        {
            return this.conexion.Espacios!
                .Where(x => x.Numero == entidad.Numero)
                .ToList();
        }

        public List<Espacios> Consultar()
        {
            return this.conexion.Espacios!.ToList();
        }

        public Espacios Insertar(Espacios entidad)
        {
            if (entidad.Id_espacio != 0)
                throw new Exception("Ya se guardo");

            if (Validar(entidad))
                throw new Exception("Falta informacion");

            this.conexion.Espacios!.Add(entidad!);
            this.conexion.SaveChanges();
            return entidad;
        }

        private bool Validar(Espacios entidad)
        {
            return entidad.Numero == 0 ||
                string.IsNullOrEmpty(entidad.Tipo_espacio) ||
                entidad.Id_nivel == 0 ||
                entidad.Id_zona == 0 ||
                entidad.Id_espacio == 0
                ;
        }
    }
}
