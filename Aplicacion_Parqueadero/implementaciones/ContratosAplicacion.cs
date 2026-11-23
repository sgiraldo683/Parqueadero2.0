using Aplicacion_Parqueadero.entidades;
using Aplicacion_Parqueadero.interfaces;
using Microsoft.EntityFrameworkCore;


namespace Aplicacion_Parqueadero.implementaciones
{
    public class ContratosAplicacion : IContratosAplicacion
    {
        private IConexion conexion;

        public ContratosAplicacion(IConexion conexion)
        {
            this.conexion = conexion;
        }

        public Contratos Actualizar(Contratos entidad)
        {
            if (entidad.Id_contrato == 0)
                throw new Exception("No se ha guardo");

            if (Validar(entidad))
                throw new Exception("Falta informacion");

            var entry = this.conexion!.Entry<Contratos>(entidad);
            entry.State = EntityState.Modified;
            this.conexion!.SaveChanges();
            return entidad;
        }

        public Contratos Borrar(Contratos entidad)
        {
            if (entidad.Id_contrato == 0)
                throw new Exception("No se ha guardo");

            this.conexion.Contratos!.Remove(entidad!);
            this.conexion.SaveChanges();
            return entidad;
        }

        public List<Contratos> Buscar(Contratos entidad)
        {
            return this.conexion.Contratos!
                .Where(x => x.Id_contrato == entidad.Id_contrato)
                .ToList();
        }

        public List<Contratos> Consultar()
        {
            return this.conexion.Contratos!.ToList();
        }

        public Contratos Insertar(Contratos entidad)
        {
            if (entidad.Id_contrato != 0)
                throw new Exception("Ya se guardo");

            if (Validar(entidad))
                throw new Exception("Falta informacion");

            this.conexion.Contratos!.Add(entidad!);
            this.conexion.SaveChanges();
            return entidad;
        }

        private bool Validar(Contratos entidad)
        {
            return entidad.Id_contrato == 0 ||
                entidad.Id_cliente == 0 ||
                entidad.Id_plan == 0 ||
                entidad.Fecha_inicio == DateTime.MinValue ||
                entidad.Fecha_fin == DateTime.MinValue;
        }
}
