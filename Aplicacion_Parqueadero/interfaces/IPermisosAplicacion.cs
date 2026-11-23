using Aplicacion_Parqueadero.entidades;


namespace Aplicacion_Parqueadero.interfaces
{
    public interface IPermisosAplicacion
    {
        Permisos Insertar(Permisos entidad);
        Permisos Actualizar(Permisos entidad);
        List<Permisos> Consultar();
        Permisos Borrar(Permisos entidad);
        List<Permisos> Buscar(Permisos entidad);
    }
}
