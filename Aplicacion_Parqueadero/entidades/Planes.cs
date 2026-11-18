using System.ComponentModel.DataAnnotations;

namespace Aplicacion_Parqueadero.entidades
{
    public class Planes
    {
        [Key]
        public int Id_plan { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public decimal Precio { get; set; }
        public int Duracion_dias { get; set; }
        public string? Descripcion { get; set; }
    }
}
