using Aplicacion_Parqueadero.entidades;
using Aplicacion_Parqueadero.interfaces;
using Presentacion_Parqueadero.interfaces;
using Presentaciones_Parqueadero.interfaces;

namespace Presentacion_Parqueadero.interfaces
{
    public class AdministradorPresentacion : IClientesPresentacion
    {
        private IComunicaciones IComunicaciones;

        

        public Administrador Actualizar(Administrador entidad)
        {
            if (entidad.Id_administrador == 0)
                throw new Exception("No se ha guardo");

            if (Validar(entidad))
                throw new Exception("Falta informacion");

            var task = this.IComunicaciones.Ejecutar<Administrador>(
                "Asignaciones/Actualizar",
                entidad);
            task.Wait();
            return task.Result;
        }

        public Administrador Borrar(Administrador entidad)
        {
            if (entidad.Id_administrador == 0)
                throw new Exception("No se ha guardo");

            var task = this.IComunicaciones.Ejecutar<Administrador>(
                "Administradores/Borrar",
                entidad);
            task.Wait();
            return task.Result;
        }

        public List<Administrador> Buscar(Administrador entidad)
        {
            var task = this.IComunicaciones.Ejecutar<List<Administrador>>(
                "Administradores/Buscar",
                entidad);
            task.Wait();
            return task.Result;
        }

        public List<Administrador> Consultar()
        {
            var task = this.IComunicaciones.Ejecutar<List<Administrador>>(
                "Administradores/Consultar",
                null);
            task.Wait();
            return task.Result;
        }

        public Administrador Insertar(Administrador entidad)
        {
            if (entidad.Id_administrador != 0)
                throw new Exception("Ya se guardo");

            if (Validar(entidad))
                throw new Exception("Falta informacion");

            var task = this.IComunicaciones.Ejecutar<Administrador>(
                "Administradores/Insertar",
                entidad);
            task.Wait();
            return task.Result;
        }

        Administrador IClientesPresentacion.Actualizar(Administrador entidad)
        {
            throw new NotImplementedException();
        }

        Administrador IClientesPresentacion.Borrar(Administrador entidad)
        {
            throw new NotImplementedException();
        }

        List<Administrador> IClientesPresentacion.Buscar(Administrador entidad)
        {
            throw new NotImplementedException();
        }

        List<Administrador> IClientesPresentacion.Consultar()
        {
            throw new NotImplementedException();
        }

        Administrador IClientesPresentacion.Insertar(Administrador entidad)
        {
            throw new NotImplementedException();
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