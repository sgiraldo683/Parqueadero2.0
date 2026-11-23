using Aplicacion_Parqueadero.entidades;


namespace Presentacion_Parqueadero.interfaces
{
    public interface IFacturasAplicacion
    {
        Facturas Insertar(Facturas entidad);
        Facturas Actualizar(Facturas entidad);
        List<Facturas> Consultar();
        Facturas Borrar(Facturas entidad);
        List<Facturas> Buscar(Facturas entidad);
    }
}
