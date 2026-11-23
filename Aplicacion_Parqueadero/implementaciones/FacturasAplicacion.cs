using Aplicacion_Parqueadero.entidades;
using Aplicacion_Parqueadero.interfaces;
using Microsoft.EntityFrameworkCore;


namespace Aplicacion_Parqueadero.implementaciones
{
    public class FacturasAplicacion : IFacturasAplicacion
    {
        private IConexion conexion;

        public FacturasAplicacion(IConexion conexion)
        {
            this.conexion = conexion;
        }

        public Facturas Actualizar(Facturas entidad)
        {
            if (entidad.Id_factura == 0)
                throw new Exception("No se ha guardo");

            if (Validar(entidad))
                throw new Exception("Falta informacion");

            var entry = this.conexion!.Entry<Facturas>(entidad);
            entry.State = EntityState.Modified;
            this.conexion!.SaveChanges();
            return entidad;
        }

        public Facturas Borrar(Facturas entidad)
        {
            if (entidad.Id_factura == 0)
                throw new Exception("No se ha guardo");

            this.conexion.Facturas!.Remove(entidad!);
            this.conexion.SaveChanges();
            return entidad;
        }

        public List<Facturas> Buscar(Facturas entidad)
        {
            return this.conexion.Facturas!
                .Where(x => x.Numero!.Contains(entidad.Numero!))
                .ToList();
        }

        public List<Facturas> Consultar()
        {
            return this.conexion.Facturas!.ToList();
        }

        public Facturas Insertar(Facturas entidad)
        {
            if (entidad.Id_factura != 0)
                throw new Exception("Ya se guardo");

            if (Validar(entidad))
                throw new Exception("Falta informacion");

            this.conexion.Facturas!.Add(entidad!);
            this.conexion.SaveChanges();
            return entidad;
        }

        private bool Validar(Facturas entidad)
        {
            return string.IsNullOrEmpty(entidad.Numero) ||
                entidad.Id_factura == 0 ||
                entidad.Subtotal == 0 ||
                entidad.Total == 0 ||
                entidad.Fecha == DateTime.MinValue

               ;
        }
    }
}
