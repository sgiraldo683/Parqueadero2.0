using Aplicacion_Parqueadero.entidades;


namespace Aplicacion_Parqueadero.interfaces
{
    public interface IAdministradorAplicacion
    {
        Administrador Insertar(Administrador entidad);
        Administrador Actualizar(Administrador entidad);
        List<Administrador> Consultar();
        Administrador Borrar(Administrador entidad);
        List<Administrador> Buscar(Administrador entidad);
    }
}
