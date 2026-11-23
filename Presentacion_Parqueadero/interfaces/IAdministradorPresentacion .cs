using Aplicacion_Parqueadero.entidades;


namespace Presentacion_Parqueadero.interfaces
{
    public interface IAdministradorPresentacion
    {
        Administrador Insertar(Administrador entidad);
        Administrador Actualizar(Administrador entidad);
        List<Administrador> Consultar();
        Administrador Borrar(Administrador entidad);
        List<Administrador> Buscar(Administrador entidad);
    }
}
