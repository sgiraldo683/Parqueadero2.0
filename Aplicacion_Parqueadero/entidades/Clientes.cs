using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aplicacion_Parqueadero.entidades
{
    public class Clientes
    {
        [Key]
        public int Id_cliente { get; set; }
        public string Nombres { get; set; } = string.Empty;
        public string Apellidos { get; set; } = string.Empty;
        public string? Documento { get; set; }
        public int Id_usuario { get; set; }
     
       
    }
}
