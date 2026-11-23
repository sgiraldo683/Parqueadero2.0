using Aplicacion_Parqueadero.entidades;


namespace Aplicacion_Parqueadero.interfaces
{
    public interface IRolesAplicacion
    {
        Roles Insertar(Roles entidad);
        Roles Actualizar(Roles entidad);
        List<Roles> Consultar();
        Roles Borrar(Roles entidad);
        List<Roles> Buscar(Roles entidad);
    }
}
