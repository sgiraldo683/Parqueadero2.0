using System.ComponentModel.DataAnnotations;

namespace Aplicacion_Parqueadero.entidades
{
    public class 0
    {
        [Key]
        public int Id_auditoria { get; set; }
        public string? Numero { get; set; }
        public DateTime Fecha_apertura { get; set; }
        public decimal Saldo_inicial { get; set; }
        public decimal Saldo_final { get; set; }
    }
}
