using Aplicacion_Parqueadero.entidades;
using Aplicacion_Parqueadero.interfaces;
using Microsoft.EntityFrameworkCore;


namespace Aplicacion_Parqueadero.implementaciones
{
    public class PromocionesAplicacion : IPromocionesAplicacion
    {
        private IConexion conexion;

        public PromocionesAplicacion(IConexion conexion)
        {
            this.conexion = conexion;
        }

        public Promociones Actualizar(Promociones entidad)
        {
            if (entidad.Id_promocion == 0)
                throw new Exception("No se ha guardo");

            if (Validar(entidad))
                throw new Exception("Falta informacion");

            var entry = this.conexion!.Entry<Promociones>(entidad);
            entry.State = EntityState.Modified;
            this.conexion!.SaveChanges();
            return entidad;
        }

        public Promociones Borrar(Promociones entidad)
        {
            if (entidad.Id_promocion == 0)
                throw new Exception("No se ha guardo");

            this.conexion.Promociones!.Remove(entidad!);
            this.conexion.SaveChanges();
            return entidad;
        }

        public List<Promociones> Buscar(Promociones entidad)
        {
            return this.conexion.Promociones!
                .Where(x => x.Nombre!.Contains(entidad.Nombre!))
                .ToList();
        }

        public List<Promociones> Consultar()
        {
            return this.conexion.Promociones!.ToList();
        }

        public Promociones Insertar(Promociones entidad)
        {
            if (entidad.Id_promocion != 0)
                throw new Exception("Ya se guardo");

            if (Validar(entidad))
                throw new Exception("Falta informacion");

            this.conexion.Promociones!.Add(entidad!);
            this.conexion.SaveChanges();
            return entidad;
        }

        private bool Validar(Promociones entidad)
        {
            return string.IsNullOrEmpty(entidad.Nombre) ||
                entidad.Descuento == 0 ||
                string.IsNullOrEmpty(entidad.Descripcion) ||
                entidad.Id_promocion == 0 ||
                entidad.Fecha_vencimiento == DateTime.MinValue;
        }
    }
}
