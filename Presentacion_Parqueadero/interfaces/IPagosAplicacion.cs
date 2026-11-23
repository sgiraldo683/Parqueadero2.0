using Aplicacion_Parqueadero.entidades;


namespace Presentacion_Parqueadero.interfaces
{
    public interface IPagosAplicacion
    {
        Pagos Insertar(Pagos entidad);
        Pagos Actualizar(Pagos entidad);
        List<Pagos> Consultar();
        Pagos Borrar(Pagos entidad);
        List<Pagos> Buscar(Pagos entidad);
    }
}
