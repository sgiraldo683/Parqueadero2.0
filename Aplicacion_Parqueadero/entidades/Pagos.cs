using System.ComponentModel.DataAnnotations;

namespace Aplicacion_Parqueadero.entidades
{
    public class Pagos
    {
        [Key]
        public int Id_pago { get; set; }
        public int? Id_factura { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Valor { get; set; }
        public string? Metodo { get; set; }
    }
}
