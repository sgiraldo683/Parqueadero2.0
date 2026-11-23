using Aplicacion_Parqueadero.entidades;


namespace Aplicacion_Parqueadero.interfaces
{
    public interface IBoletosAplicacion
    {
        Boletos Insertar(Boletos entidad);
        Boletos Actualizar(Boletos entidad);
        List<Boletos> Consultar();
        Boletos Borrar(Boletos entidad);
        List<Boletos> Buscar(Boletos entidad);
    }
}
