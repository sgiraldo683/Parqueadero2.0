using Aplicacion_Parqueadero.entidades;


namespace Aplicacion_Parqueadero.interfaces
{
    public interface IUsuarioAplicacion
    {
        Usuarios Insertar(Usuarios entidad);
        Usuarios Actualizar(Usuarios entidad);
        List<Usuarios> Consultar();
        Usuarios Borrar(Usuarios entidad);
        List<Usuarios> Buscar(Usuarios entidad);
    }
}
