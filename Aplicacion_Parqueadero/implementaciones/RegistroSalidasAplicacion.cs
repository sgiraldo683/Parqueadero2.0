using Aplicacion_Parqueadero.entidades;
using Aplicacion_Parqueadero.interfaces;
using Microsoft.EntityFrameworkCore;


namespace Aplicacion_Parqueadero.implementaciones
{
    public class RegistroSalidasAplicacion : IRegistroSalidasAplicacion
    {
        private IConexion conexion;

        public RegistroSalidasAplicacion(IConexion conexion)
        {
            this.conexion = conexion;
        }

        public RegistroSalidas Actualizar(RegistroSalidas entidad)
        {
            if (entidad.Id_salida == 0)
                throw new Exception("No se ha guardo");

            if (Validar(entidad))
                throw new Exception("Falta informacion");

            var entry = this.conexion!.Entry<RegistroSalidas>(entidad);
            entry.State = EntityState.Modified;
            this.conexion!.SaveChanges();
            return entidad;
        }

        public RegistroSalidas Borrar(RegistroSalidas entidad)
        {
            if (entidad.Id_salida == 0)
                throw new Exception("No se ha guardo");

            this.conexion.RegistroSalidas!.Remove(entidad!);
            this.conexion.SaveChanges();
            return entidad;
        }

        public List<RegistroSalidas> Buscar(RegistroSalidas entidad)
        {
            return this.conexion.RegistroSalidas!
                .Where(x => x.Id_salida == entidad.Id_salida)
                .ToList();
        }

        public List<RegistroSalidas> Consultar()
        {
            return this.conexion.RegistroSalidas!.ToList();
        }

        public RegistroSalidas Insertar(RegistroSalidas entidad)
        {
            if (entidad.Id_salida != 0)
                throw new Exception("Ya se guardo");

            if (Validar(entidad))
                throw new Exception("Falta informacion");

            this.conexion.RegistroSalidas!.Add(entidad!);
            this.conexion.SaveChanges();
            return entidad;
        }

        private bool Validar(RegistroSalidas entidad)
        {
            return entidad.Id_salida == 0 ||
                entidad.Id_ticket == 0 ||
                entidad.Fecha_salida == DateTime.MinValue ||
                entidad.Hora_salida == TimeSpan.MinValue ||
                string.IsNullOrEmpty(entidad.Observacion);
        }
    }
}

        }
    }
}
