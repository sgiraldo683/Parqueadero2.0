using Aplicacion_Parqueadero.entidades;


namespace Presentacion_Parqueadero.interfaces
{
    public interface ICierreCajaPresentacion
    {
        CierreCaja Insertar(CierreCaja entidad);
        CierreCaja Actualizar(CierreCaja entidad);
        List<CierreCaja> Consultar();
        CierreCaja Borrar(CierreCaja entidad);
        List<CierreCaja> Buscar(CierreCaja entidad);
    }
}
