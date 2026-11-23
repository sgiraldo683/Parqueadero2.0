using Aplicacion_Parqueadero.entidades;


namespace Aplicacion_Parqueadero.interfaces
{
    public interface ITarifasAplicacion
    {
        Tarifas Insertar(Tarifas entidad);
        Tarifas Actualizar(Tarifas entidad);
        List<Tarifas> Consultar();
        Tarifas Borrar(Tarifas entidad);
        List<Tarifas> Buscar(Tarifas entidad);
    }
}
