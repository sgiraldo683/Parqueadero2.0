using Aplicacion_Parqueadero.entidades;


namespace Aplicacion_Parqueadero.interfaces
{
    public interface ICierreCajasAplicacion

    {
        CierreCajas Insertar(CierreCajas entidad);
        CierreCajas Actualizar(CierreCajas entidad);
        List<CierreCajas> Consultar();
        CierreCajas Borrar(CierreCajas entidad);
        List<CierreCajas> Buscar(CierreCajas entidad);
    }
}
