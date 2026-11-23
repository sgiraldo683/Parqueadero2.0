using Aplicacion_Parqueadero.entidades;
using Aplicacion_Parqueadero.interfaces;
using Microsoft.EntityFrameworkCore;


namespace Aplicacion_Parqueadero.implementaciones
{
    public class CierreCajaAplicacion : IRegistroSalidasAplicacion
    {
        private IConexion conexion;

        public CierreCajaAplicacion(IConexion conexion)
        {
            this.conexion = conexion;
        }

        public Clientes Actualizar(Clientes entidad)
        {
            if (entidad.Id_cliente == 0)
                throw new Exception("No se ha guardo");

            if (Validar(entidad))
                throw new Exception("Falta informacion");

            var entry = this.conexion!.Entry<Clientes>(entidad);
            entry.State = EntityState.Modified;
            this.conexion!.SaveChanges();
            return entidad;
        }

        public Clientes Borrar(Clientes entidad)
        {
            if (entidad.Id_cliente == 0)
                throw new Exception("No se ha guardo");

            this.conexion.Clientes!.Remove(entidad!);
            this.conexion.SaveChanges();
            return entidad;
        }

        public List<Clientes> Buscar(Clientes entidad)
        {
            return this.conexion.Clientes!
                .Where(x => x.Nombres!.Contains(entidad.Nombres!))
                .ToList();
        }

        public List<Clientes> Consultar()
        {
            return this.conexion.Clientes!.ToList();
        }

        public Clientes Insertar(Clientes entidad)
        {
            if (entidad.Id_cliente != 0)
                throw new Exception("Ya se guardo");

            if (Validar(entidad))
                throw new Exception("Falta informacion");

            this.conexion.Clientes!.Add(entidad!);
            this.conexion.SaveChanges();
            return entidad;
        }

        private bool Validar(Clientes entidad)
        {
            return string.IsNullOrEmpty(entidad.Nombres) ||
                string.IsNullOrEmpty(entidad.Apellidos) ||
                string.IsNullOrEmpty(entidad.Documento) ||
                string.IsNullOrEmpty(entidad.Telefono);
        }
    }
}
