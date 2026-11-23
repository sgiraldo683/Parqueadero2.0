using Aplicacion_Parqueadero.entidades;


namespace Presentacion_Parqueadero.interfaces
{
    public interface IEspaciosPresentacion
    {
        Espacios Insertar(Espacios entidad);
        Espacios Actualizar(Espacios entidad);
        List<Espacios> Consultar();
        Espacios Borrar(Espacios entidad);
        List<Espacios> Buscar(Espacios entidad);
    }
}
