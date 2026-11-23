using Aplicacion_Parqueadero.entidades;


namespace Presentacion_Parqueadero.interfaces
{
    public interface IVehiculosAplicacion
    {
        Vehiculos Insertar(Vehiculos entidad);
        Vehiculos Actualizar(Vehiculos entidad);
        List<Vehiculos> Consultar();
        Vehiculos Borrar(Vehiculos entidad);
        List<Vehiculos> Buscar(Vehiculos entidad);
    }
}
