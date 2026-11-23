using Aplicacion_Parqueadero.entidades;


namespace Aplicacion_Parqueadero.interfaces
{
    public interface IAuditoriasAplicacion
    {
        Auditorias Insertar(Auditorias entidad);
        Auditorias Actualizar(Auditorias entidad);
        List<Auditorias> Consultar();
        Auditorias Borrar(Auditorias entidad);
        List<Auditorias> Buscar(Auditorias entidad);
    }
}
