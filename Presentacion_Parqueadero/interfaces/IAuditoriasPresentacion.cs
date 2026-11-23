using Aplicacion_Parqueadero.entidades;


namespace Presentacion_Parqueadero.interfaces
{
    public interface IAuditoriasPresentacion
    {
        Auditorias Insertar(Auditorias entidad);
        Auditorias Actualizar(Auditorias entidad);
        List<Auditorias> Consultar();
        Auditorias Borrar(Auditorias entidad);
        List<Auditorias> Buscar(Auditorias entidad);
    }
}
