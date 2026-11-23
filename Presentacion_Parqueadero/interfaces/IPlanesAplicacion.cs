using Aplicacion_Parqueadero.entidades;


namespace Presentacion_Parqueadero.interfaces
{
    public interface IPlanesAplicacion
    {
        Planes Insertar(Planes entidad);
        Planes Actualizar(Planes entidad);
        List<Planes> Consultar();
        Planes Borrar(Planes entidad);
        List<Planes> Buscar(Planes entidad);
    }
}
