using System.ComponentModel.DataAnnotations;

namespace Aplicacion_Parqueadero.entidades
{
    public class Boletos
    {
        [Key]
        public int Id_ticket { get; set; }
        public string? Codigo { get; set; }
        public DateTime Fecha_entrada { get; set; }
        public TimeSpan Hora_entrada { get; set; }
        public int? Id_vehiculo { get; set; }
    }
}
