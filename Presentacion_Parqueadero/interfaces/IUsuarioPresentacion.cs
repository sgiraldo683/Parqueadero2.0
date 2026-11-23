using Aplicacion_Parqueadero.entidades;


namespace Presentacion_Parqueadero.interfaces
{
    public interface IUsuarioPresentacion
    {
        Usuarios Insertar(Usuarios entidad);
        Usuarios Actualizar(Usuarios entidad);
        List<Usuarios> Consultar();
        Usuarios Borrar(Usuarios entidad);
        List<Usuarios> Buscar(Usuarios entidad);
    }
}
