using System.ComponentModel.DataAnnotations;

namespace Aplicacion_Parqueadero.entidades
{
    public class Administrador
    {
        [Key]
        public int Id_administrador { get; set; }
        public string? Nombres { get; set; }
        public string? Apellidos { get; set; }
        public string? Documento { get; set; }
        public string? Telefono { get; set; }
    }
}
