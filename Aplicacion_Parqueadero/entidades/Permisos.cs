using System.ComponentModel.DataAnnotations;

namespace Aplicacion_Parqueadero.entidades
{
    public class Permisos
    {
        [Key]
        public int Id_Permisos { get; set; }
        public string? Descripcion { get; set; }
        public int Id_Usuario{ get; set; }

    }
}
