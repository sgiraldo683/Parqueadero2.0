using Aplicacion_Parqueadero.entidades;


namespace Presentacion_Parqueadero.interfaces
{
    public interface IPermisosPresentacion
    {
        Permisos Insertar(Permisos entidad);
        Permisos Actualizar(Permisos entidad);
        List<Permisos> Consultar();
        Permisos Borrar(Permisos entidad);
        List<Permisos> Buscar(Permisos entidad);
    }
}
