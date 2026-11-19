using Aplicacion_Parqueadero.entidades;
using Microsoft.EntityFrameworkCore;

namespace Pruebas_Parqueadero
{
    [TestClass]
    public class RegistroSalidasPruebas : PruebaBase
    {
        private RegistroSalidas? entidad = null;

        [TestMethod]
        public void Execute()
        {
            try
            {
                Insertar();
                Consultar();
                Actualizar();
                Borrar();
            }
            finally
            {
                Limpiar();
            }
        }

        public void Insertar()
        {
            var boleto = CrearBoleto();
            this.entidad = new RegistroSalidas()
            {
                Id_ticket = boleto.Id_ticket,
                Fecha_salida = DateTime.Today,
                Hora_salida = new TimeSpan(12, 0, 0),
                Observacion = "Salida normal"
            };
            this.conexion.RegistroSalidas!.Add(this.entidad!);
            this.conexion.SaveChanges();
            Registrar(this.entidad);
        }

        public void Consultar()
        {
            var lista = this.conexion.RegistroSalidas!.ToList();
            if (lista.Count <= 0)
                throw new Exception("Lista vacia");
        }

        private void Actualizar()
        {
            this.entidad!.Observacion = "Salida con retraso";
            var entry = this.conexion!.Entry<RegistroSalidas>(this.entidad!);
            entry.State = EntityState.Modified;
            this.conexion!.SaveChanges();
        }

        private void Borrar()
        {
            this.conexion.RegistroSalidas!.Remove(this.entidad!);
            this.conexion.SaveChanges();
        }
    }
}
