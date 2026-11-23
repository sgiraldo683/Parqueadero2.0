using Aplicacion_Parqueadero.entidades;


namespace Presentacion_Parqueadero.interfaces
{
    public interface ITrabajadoresAplicacion
    {
        Trabajadores Insertar(Trabajadores entidad);
        Trabajadores Actualizar(Trabajadores entidad);
        List<Trabajadores> Consultar();
        Trabajadores Borrar(Trabajadores entidad);
        List<Trabajadores> Buscar(Trabajadores entidad);
    }
}
