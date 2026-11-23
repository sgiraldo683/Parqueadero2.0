using Aplicacion_Parqueadero.entidades;


namespace Presentacion_Parqueadero.interfaces
{
    public interface IPromocionesPresentacion
    {
        Promociones Insertar(Promociones entidad);
        Promociones Actualizar(Promociones entidad);
        List<Promociones> Consultar();
        Promociones Borrar(Promociones entidad);
        List<Promociones> Buscar(Promociones entidad);
    }
}
