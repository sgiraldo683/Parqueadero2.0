using System.ComponentModel.DataAnnotations;

namespace Aplicacion_Parqueadero.entidades
{
    public class Niveles
    {
        [Key]
        public int Id_nivel { get; set; }
        public string? Nombre { get; set; }
        public int Numero { get; set; }
        public int Capacidad { get; set; }
        public string? Ubicacion { get; set; }
    }
}
