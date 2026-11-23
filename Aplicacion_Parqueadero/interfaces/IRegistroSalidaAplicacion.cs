using Aplicacion_Parqueadero.entidades;


namespace Aplicacion_Parqueadero.interfaces
{
    public interface IRegistroSalidasAplicacion
    {
        RegistroSalidas Insertar(RegistroSalidas entidad);
        RegistroSalidas Actualizar(RegistroSalidas entidad);
        List<RegistroSalidas> Consultar();
        RegistroSalidas Borrar(RegistroSalidas entidad);
        List<RegistroSalidas> Buscar(RegistroSalidas entidad);
    }
}
