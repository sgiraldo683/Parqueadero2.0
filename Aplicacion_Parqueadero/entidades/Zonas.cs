using System.ComponentModel.DataAnnotations;

namespace Aplicacion_Parqueadero.entidades
{
    public class Zonas
    {
        [Key]
        public int Id_zona { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public string? Tipo_Zona { get; set; }
        public int Capacidad { get; set; }
    }
}
