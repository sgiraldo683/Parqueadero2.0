using Aplicacion_Parqueadero.entidades;


namespace Presentacion_Parqueadero.interfaces
{
    public interface ITurnosPresentacion
    {
        Turnos Insertar(Turnos entidad);
        Turnos Actualizar(Turnos entidad);
        List<Turnos> Consultar();
        Turnos Borrar(Turnos entidad);
        List<Turnos> Buscar(Turnos entidad);
    }
}
