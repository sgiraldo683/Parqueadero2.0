using Aplicacion_Parqueadero.entidades;


namespace Aplicacion_Parqueadero.interfaces
{
    public interface ITurnosAplicacion
    {
        Turnos Insertar(Turnos entidad);
        Turnos Actualizar(Turnos entidad);
        List<Turnos> Consultar();
        Turnos Borrar(Turnos entidad);
        List<Turnos> Buscar(Turnos entidad);
    }
}
