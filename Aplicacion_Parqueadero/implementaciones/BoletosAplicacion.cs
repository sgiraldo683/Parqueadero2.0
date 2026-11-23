using Aplicacion_Parqueadero.entidades;
using Aplicacion_Parqueadero.interfaces;
using Microsoft.EntityFrameworkCore;


namespace Aplicacion_Parqueadero.implementaciones
{
    public class BoletosAplicacion : IBoletosAplicacion
    {
        private IConexion conexion;

        public BoletosAplicacion(IConexion conexion)
        {
            this.conexion = conexion;
        }

        public Boletos Actualizar(Boletos entidad)
        {
            if (entidad.Id_ticket == 0)
                throw new Exception("No se ha guardo");

            if (Validar(entidad))
                throw new Exception("Falta informacion");

            var entry = this.conexion!.Entry<Boletos>(entidad);
            entry.State = EntityState.Modified;
            this.conexion!.SaveChanges();
            return entidad;
        }

        public Boletos Borrar(Boletos entidad)
        {
            if (entidad.Id_ticket == 0)
                throw new Exception("No se ha guardo");

            this.conexion.Boletos!.Remove(entidad!);
            this.conexion.SaveChanges();
            return entidad;
        }

        public List<Boletos> Buscar(Boletos entidad)
        {
            return this.conexion.Boletos!
                .Where(x => x.Codigo!.Contains(entidad.Codigo!))
                .ToList();
        }

        public List<Boletos> Consultar()
        {
            return this.conexion.Boletos!.ToList();
        }

        public Boletos Insertar(Boletos entidad)
        {
            if (entidad.Id_ticket != 0)
                throw new Exception("Ya se guardo");

            if (Validar(entidad))
                throw new Exception("Falta informacion");

            this.conexion.Boletos!.Add(entidad!);
            this.conexion.SaveChanges();
            return entidad;
        }

        private bool Validar(Boletos entidad)
        {
            return string.IsNullOrEmpty(entidad.Codigo) ||
                entidad.Id_ticket == 0 ||
                entidad.Id_vehiculo==0;
        }
    }
}
