using Aplicacion_Parqueadero.entidades;


namespace Aplicacion_Parqueadero.interfaces
{
    public interface IEspaciosAplicacion
    {
        Espacios Insertar(Espacios entidad);
        Espacios Actualizar(Espacios entidad);
        List<Espacios> Consultar();
        Espacios Borrar(Espacios entidad);
        List<Espacios> Buscar(Espacios entidad);
    }
}
