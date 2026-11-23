using System.ComponentModel.DataAnnotations;

namespace Aplicacion_Parqueadero.entidades
{
    public class Tipos_Trabajadores
    {
        [Key]
        public int Id_Tipo{ get; set; }
        public string? Nombre { get; set; }
    }
}
