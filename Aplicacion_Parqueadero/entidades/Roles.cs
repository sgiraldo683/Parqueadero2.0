using System.ComponentModel.DataAnnotations;

namespace Aplicacion_Parqueadero.entidades
{
    public class Roles
    {
        [Key]
        public int Id_rol { get; set; }
        public string? Nombre { get; set; }
        
    }
}
