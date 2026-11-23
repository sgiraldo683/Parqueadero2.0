using Aplicacion_Parqueadero.entidades;


namespace Presentacion_Parqueadero.interfaces
{
    public interface IUsuarioPresentacion
    {
        Usuario Insertar(Usuario entidad);
        Usuario Actualizar(Usuario entidad);
        List<Usuario> Consultar();
        Usuario Borrar(Usuario entidad);
        List<Usuario> Buscar(Usuario entidad);
    }
}
