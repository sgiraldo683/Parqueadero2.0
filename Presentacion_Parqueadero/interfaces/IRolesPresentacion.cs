using Aplicacion_Parqueadero.entidades;


namespace Presentacion_Parqueadero.interfaces
{
    public interface IRolesPresentacion
    {
        Roles Insertar(Roles entidad);
        Roles Actualizar(Roles entidad);
        List<Roles> Consultar();
        Roles Borrar(Roles entidad);
        List<Roles> Buscar(Roles entidad);
    }
}
