using Aplicacion_Parqueadero.entidades;


namespace Presentacion_Parqueadero.interfaces
{
    public interface IPenalizacionesPresentacion
    {
        Penalizaciones Insertar(Penalizaciones entidad);
        Penalizaciones Actualizar(Penalizaciones entidad);
        List<Penalizaciones> Consultar();
        Penalizaciones Borrar(Penalizaciones entidad);
        List<Penalizaciones> Buscar(Penalizaciones entidad);
    }
}
