using Aplicacion_Parqueadero.entidades;


namespace Aplicacion_Parqueadero.interfaces
{
    public interface INivelesAplicacion
    {
        Niveles Insertar(Niveles entidad);
        Niveles Actualizar(Niveles entidad);
        List<Niveles> Consultar();
        Niveles Borrar(Niveles entidad);
        List<Niveles> Buscar(Niveles entidad);
    }
}
