using Aplicacion_Parqueadero.entidades;


namespace Aplicacion_Parqueadero.interfaces
{
    public interface IUsuarioAplicacion
    {
        Usuario Insertar(Usuario entidad);
        Usuario Actualizar(Usuario entidad);
        List<Usuario> Consultar();
        Usuario Borrar(Usuario entidad);
        List<Usuario> Buscar(Usuario entidad);
    }
}
