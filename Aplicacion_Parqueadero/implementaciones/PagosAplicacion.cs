using Aplicacion_Parqueadero.entidades;
using Aplicacion_Parqueadero.interfaces;
using Microsoft.EntityFrameworkCore;


namespace Aplicacion_Parqueadero.implementaciones
{
    public class PagosAplicacion : IPagosAplicacion
    {
        private IConexion conexion;

        public PagosAplicacion(IConexion conexion)
        {
            this.conexion = conexion;
        }

        public Pagos Actualizar(Pagos entidad)
        {
            if (entidad.Id_pago == 0)
                throw new Exception("No se ha guardo");

            if (Validar(entidad))
                throw new Exception("Falta informacion");

            var entry = this.conexion!.Entry<Pagos>(entidad);
            entry.State = EntityState.Modified;
            this.conexion!.SaveChanges();
            return entidad;
        }

        public Pagos Borrar(Pagos entidad)
        {
            if (entidad.Id_pago == 0)
                throw new Exception("No se ha guardo");

            this.conexion.Pagos!.Remove(entidad!);
            this.conexion.SaveChanges();
            return entidad;
        }

        public List<Pagos> Buscar(Pagos entidad)
        {
            return this.conexion.Pagos!
                .Where(x => x.Id_pago.ToString() == entidad.Id_pago.ToString())
                .ToList();
        }

        public List<Pagos> Consultar()
        {
            return this.conexion.Pagos!.ToList();
        }

        public Pagos Insertar(Pagos entidad)
        {
            if (entidad.Id_pago != 0)
                throw new Exception("Ya se guardo");

            if (Validar(entidad))
                throw new Exception("Falta informacion");

            this.conexion.Pagos!.Add(entidad!);
            this.conexion.SaveChanges();
            return entidad;
        }

        private bool Validar(Pagos entidad)
        {
            return string.IsNullOrEmpty(entidad.Metodo) ||
                entidad.Id_pago == 0 ||
                entidad.Id_factura == 0 ||
                entidad.Fecha == DateTime.MinValue ||
                entidad.Valor == 0;
        }
    }
}
