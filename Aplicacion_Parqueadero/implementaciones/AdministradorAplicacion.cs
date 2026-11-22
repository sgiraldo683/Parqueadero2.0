using Aplicacion_Parqueadero.entidades;
using Aplicacion_Parqueadero.interfaces;
using Microsoft.EntityFrameworkCore;


namespace Aplicacion_Parqueadero.implementaciones
{
    public class AdministadorsAplicacion : IAdministadorAplicacion
    {
        private IConexion conexion;

        public AdministadorsAplicacion(IConexion conexion)
        {
            this.conexion = conexion;
        }

        public Administador Actualizar(Administador entidad)
        {
            if (entidad.Id_administrador == 0)
                throw new Exception("No se ha guardo");

            if (Validar(entidad))
                throw new Exception("Falta informacion");

            var entry = this.conexion!.Entry<Administrador>(entidad);
            entry.State = EntityState.Modified;
            this.conexion!.SaveChanges();
            return entidad;
        }

        public Administrador Borrar(Administrador entidad)
        {
            if (entidad.Id_administrador == 0)
                throw new Exception("No se ha guardo");

            this.conexion.Administradores!.Remove(entidad!);
            this.conexion.SaveChanges();
            return entidad;
        }

        public List<Administrador> Buscar(Administrador entidad)
        {
            return this.conexion.Administradores!
                .Where(x => x.Nombres!.Contains(entidad.Nombres!))
                .ToList();
        }

        public List<Administrador> Consultar()
        {
            return this.conexion.Administradores!.ToList();
        }

        public Administrador Insertar(Administrador entidad)
        {
            if (entidad.Id_administrador != 0)
                throw new Exception("Ya se guardo");

            if (Validar(entidad))
                throw new Exception("Falta informacion");

            this.conexion.Administradores!.Add(entidad!);
            this.conexion.SaveChanges();
            return entidad;
        }

        private bool Validar(Administrador entidad)
        {
            return string.IsNullOrEmpty(entidad.Nombres) ||
                string.IsNullOrEmpty(entidad.Apellidos) ||
                string.IsNullOrEmpty(entidad.Documento) ||
                string.IsNullOrEmpty(entidad.Telefono);
        }
    }
}
