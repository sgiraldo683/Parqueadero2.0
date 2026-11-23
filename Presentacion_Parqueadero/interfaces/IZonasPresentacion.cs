using Aplicacion_Parqueadero.entidades;


namespace Presentacion_Parqueadero.interfaces
{
    public interface IZonasPresentacion
    {
        Zonas Insertar(Zonas entidad);
        Zonas Actualizar(Zonas entidad);
        List<Zonas> Consultar();
        Zonas Borrar(Zonas entidad);
        List<Zonas> Buscar(Zonas entidad);
    }
}
