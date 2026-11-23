using Aplicacion_Parqueadero.entidades;


namespace Presentacion_Parqueadero.interfaces
{
    public interface ICierreCajaPresentacion
    {
        CierreCajas Insertar(CierreCajas entidad);
        CierreCajas Actualizar(CierreCajas entidad);
        List<CierreCajas> Consultar();
        CierreCajas Borrar(CierreCajas entidad);
        List<CierreCajas> Buscar(CierreCajas entidad);
    }
}
