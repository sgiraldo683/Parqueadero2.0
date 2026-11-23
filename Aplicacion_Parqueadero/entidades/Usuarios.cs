using System.ComponentModel.DataAnnotations;

namespace Aplicacion_Parqueadero.entidades
{
    public class Usuarios
    {
        [Key]
        public int Id_usuario { get; set; }
        public int Id_rol { get; set; }
        public string? Correo{ get; set; }
        public string? Contraseña{ get; set; }
        public bool Estado { get; set; }
       

    }
}
