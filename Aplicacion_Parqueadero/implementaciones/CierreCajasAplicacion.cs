using Aplicacion_Parqueadero.entidades;
using Aplicacion_Parqueadero.interfaces;
using Microsoft.EntityFrameworkCore;


namespace Aplicacion_Parqueadero.implementaciones
{
    public class CierreCajasAplicacion : ICierreCajasAplicacion
    {
        private IConexion conexion;

        public CierreCajasAplicacion(IConexion conexion)
        {
            this.conexion = conexion;
        }

        public CierreCajas Actualizar(CierreCajas entidad)
        {
            if (entidad.Id_caja == 0)
                throw new Exception("No se ha guardo");

            if (Validar(entidad))
                throw new Exception("Falta informacion");

            var entry = this.conexion!.Entry<CierreCajas>(entidad);
            entry.State = EntityState.Modified;
            this.conexion!.SaveChanges();
            return entidad;
        }

        public CierreCajas Borrar(CierreCajas entidad)
        {
            if (entidad.Id_caja == 0)
                throw new Exception("No se ha guardo");

            this.conexion.CierreCaja!.Remove(entidad!);
            this.conexion.SaveChanges();
            return entidad;
        }

        public List<CierreCajas> Buscar(CierreCajas entidad)
        {
            return this.conexion.CierreCaja!
                .Where(x => x.Numero!.Contains(entidad.Numero!))
                .ToList();
        }

        public List<CierreCajas> Consultar()
        {
            return this.conexion.CierreCaja!.ToList();
        }

        public CierreCajas Insertar(CierreCajas entidad)
        {
            if (entidad.Id_caja != 0)
                throw new Exception("Ya se guardo");

            if (Validar(entidad))
                throw new Exception("Falta informacion");

            this.conexion.CierreCaja!.Add(entidad!);
            this.conexion.SaveChanges();
            return entidad;
        }

        private bool Validar(CierreCajas entidad)
        {
            return string.IsNullOrEmpty(entidad.Numero) ||
                entidad.Fecha_apertura == DateTime.MinValue ||
                entidad.Id_caja == 0 ||
                entidad.Saldo_inicial == 0 ||
                entidad.Saldo_final == 0;
        }
    }
}

