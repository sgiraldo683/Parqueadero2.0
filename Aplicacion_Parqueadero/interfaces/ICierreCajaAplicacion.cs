using Aplicacion_Parqueadero.entidades;


namespace Aplicacion_Parqueadero.interfaces
{
    public interface ICierreCajaAplicacion
    {
        CierreCaja Insertar(CierreCaja entidad);
        CierreCaja Actualizar(CierreCaja entidad);
        List<CierreCaja> Consultar();
        CierreCaja Borrar(CierreCaja entidad);
        List<CierreCaja> Buscar(CierreCaja entidad);
    }
}
