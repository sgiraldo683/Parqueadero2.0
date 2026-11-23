using Aplicacion_Parqueadero.entidades;
using Aplicacion_Parqueadero.interfaces;
using Microsoft.EntityFrameworkCore;


namespace Aplicacion_Parqueadero.implementaciones
{
    public class Tipos_TrabajadoresAplicacion : ITipos_TrabajadoresAplicacion
    {
        private IConexion conexion;

        public Tipos_TrabajadoresAplicacion(IConexion conexion)
        {
            this.conexion = conexion;
        }

        public Tipos_Trabajadores Actualizar(Tipos_Trabajadores entidad)
        {
            if (entidad.Id_Tipo == 0)
                throw new Exception("No se ha guardo");

            if (Validar(entidad))
                throw new Exception("Falta informacion");

            var entry = this.conexion!.Entry<Tipos_Trabajadores>(entidad);
            entry.State = EntityState.Modified;
            this.conexion!.SaveChanges();
            return entidad;
        }

        public Tipos_Trabajadores Borrar(Tipos_Trabajadores entidad)
        {
            if (entidad.Id_Tipo == 0)
                throw new Exception("No se ha guardo");

            bool v = this.conexion.Tipos_Trabajadores!.Remove(entidad!);
            this.conexion.SaveChanges();
            return entidad;
        }

        public List<Tipos_Trabajadores> Buscar(Tipos_Trabajadores entidad)
        {
            return this.conexion.Tipos_Trabajadores!
                .Where(x => x.Nombre!.Contains(entidad.Nombre!))
                .ToList();
        }

        public List<Tipos_Trabajadores> Consultar()
        {
            return this.conexion.Tipos_Trabajadores!.ToList();
        }

        public Tipos_Trabajadores Insertar(Tipos_Trabajadores entidad)
        {
            if (entidad.Id_Tipo != 0)
                throw new Exception("Ya se guardo");

            if (Validar(entidad))
                throw new Exception("Falta informacion");

            this.conexion.Tipos_Trabajadores!.Add(entidad!);
            this.conexion.SaveChanges();
            return entidad;
        }

        private bool Validar(Tipos_Trabajadores entidad)
        {
            return string.IsNullOrEmpty(entidad.Nombre);
        }
    }
}
