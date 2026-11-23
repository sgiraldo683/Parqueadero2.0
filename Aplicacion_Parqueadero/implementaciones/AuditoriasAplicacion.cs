using Aplicacion_Parqueadero.entidades;
using Aplicacion_Parqueadero.interfaces;
using Microsoft.EntityFrameworkCore;


namespace Aplicacion_Parqueadero.implementaciones
{
    public class AuditoriasAplicacion : IAuditoriasAplicacion
    {
        private IConexion conexion;

        public AuditoriasAplicacion(IConexion conexion)
        {
            this.conexion = conexion;
        }

        public Auditorias Actualizar(Auditorias entidad)
        {
            if (entidad.Id_auditoria == 0)
                throw new Exception("No se ha guardo");

            if (Validar(entidad))
                throw new Exception("Falta informacion");

            var entry = this.conexion!.Entry<Auditorias>(entidad);
            entry.State = EntityState.Modified;
            this.conexion!.SaveChanges();
            return entidad;
        }

        public Auditorias Borrar(Auditorias entidad)
        {
            if (entidad.Id_auditoria== 0)
                throw new Exception("No se ha guardo");

            this.conexion.Auditorias!.Remove(entidad!);
            this.conexion.SaveChanges();
            return entidad;
        }

        public List<Auditorias> Buscar(Auditorias entidad)
        {
            return this.conexion.Auditorias!
                .Where(x => x.Nombres!.Contains(entidad.Nombres!))
                .ToList();
        }

        public List<Auditorias> Consultar()
        {
            return this.conexion.Auditorias!.ToList();
        }

        public Auditorias Insertar(Auditorias entidad)
        {
            if (entidad.Id_auditorias != 0)
                throw new Exception("Ya se guardo");

            if (Validar(entidad))
                throw new Exception("Falta informacion");

            this.conexion.Auditorias!.Add(entidad!);
            this.conexion.SaveChanges();
            return entidad;
        }

        private bool Validar(Auditorias entidad)
        {
            return string.IsNullOrEmpty(entidad.Nombres) ||
                string.IsNullOrEmpty(entidad.Apellidos) ||
                string.IsNullOrEmpty(entidad.Documento) ||
                string.IsNullOrEmpty(entidad.Telefono);
        }
    }
}
