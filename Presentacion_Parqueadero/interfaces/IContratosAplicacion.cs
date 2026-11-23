using Aplicacion_Parqueadero.entidades;


namespace Presentacion_Parqueadero.interfaces
{
    public interface IContratosAplicacion
    {
        Contratos Insertar(Contratos entidad);
        Contratos Actualizar(Contratos entidad);
        List<Contratos> Consultar();
        Contratos Borrar(Contratos entidad);
        List<Contratos> Buscar(Contratos entidad);
    }
}
