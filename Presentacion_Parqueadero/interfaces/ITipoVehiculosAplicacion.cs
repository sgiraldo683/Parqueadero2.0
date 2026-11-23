using Aplicacion_Parqueadero.entidades;


namespace Presentacion_Parqueadero.interfaces
{
    public interface ITipoVehiculosAplicacion
    {
        TipoVehiculos Insertar(TipoVehiculos entidad);
        TipoVehiculos Actualizar(TipoVehiculos entidad);
        List<TipoVehiculos> Consultar();
        TipoVehiculos Borrar(TipoVehiculos entidad);
        List<TipoVehiculos> Buscar(TipoVehiculos entidad);
    }
}
