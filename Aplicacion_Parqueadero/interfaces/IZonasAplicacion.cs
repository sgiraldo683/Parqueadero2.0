using Aplicacion_Parqueadero.entidades;


namespace Aplicacion_Parqueadero.interfaces
{
    public interface IZonasAplicacion
    {
        Zonas Insertar(Zonas entidad);
        Zonas Actualizar(Zonas entidad);
        List<Zonas> Consultar();
        Zonas Borrar(Zonas entidad);
        List<Zonas> Buscar(Zonas entidad);
    }
}
