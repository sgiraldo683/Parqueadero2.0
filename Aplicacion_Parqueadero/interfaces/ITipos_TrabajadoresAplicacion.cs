using Aplicacion_Parqueadero.entidades;


namespace Aplicacion_Parqueadero.interfaces
{
    public interface ITipos_TrabajadoresAplicacion
    {
        Tipos_Trabajadores Insertar(Tipos_Trabajadores entidad);
        Tipos_Trabajadores Actualizar(Tipos_Trabajadores entidad);
        List<Tipos_Trabajadores> Consultar();
        Tipos_Trabajadores Borrar(Tipos_Trabajadores entidad);
        List<Tipos_Trabajadores> Buscar(Tipos_Trabajadores entidad);
    }
}
