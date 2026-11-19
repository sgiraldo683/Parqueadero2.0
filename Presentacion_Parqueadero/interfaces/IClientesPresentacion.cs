using Aplicacion_Parqueadero.entidades;


namespace Presentacion_Parqueadero.interfaces
{
    public interface IClientesPresentacion
    {
        Clientes Insertar(Clientes entidad);
        Clientes Actualizar(Clientes entidad);
        List<Clientes> Consultar();
        List<Clientes> Buscar(Clientes entidad);
        Clientes Borrar(Clientes entidad);
    }
}
