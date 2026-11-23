using Aplicacion_Parqueadero.entidades;


namespace Presentacion_Parqueadero.interfaces
{
    public interface ITurnosPresentacion
    {
        Boletos Insertar(Boletos entidad);
        Boletos Actualizar(Boletos entidad);
        List<Boletos> Consultar();
        Boletos Borrar(Boletos entidad);
        List<Clientes> Buscar(Clientes entidad);
    }
}
