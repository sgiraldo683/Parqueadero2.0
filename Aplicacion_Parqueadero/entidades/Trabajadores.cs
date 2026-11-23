using System.ComponentModel.DataAnnotations;

namespace Aplicacion_Parqueadero.entidades
{
    public class Trabajadores
    {
        [Key]
        public int Id_trabajador { get; set; }
        public string? Nombres { get; set; }
        public string? Apellidos { get; set; }
        public string? Documento { get; set; }
        public int? Tipo_trabajador { get; set; }
    }
}
