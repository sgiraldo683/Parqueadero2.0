using Aplicacion_Parqueadero.entidades;
using Microsoft.EntityFrameworkCore;

namespace Pruebas_Parqueadero
{
    [TestClass]
    public class PagosPruebas : PruebaBase
    {
        private Pagos? entidad = null;

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
            var factura = CrearFactura();
            this.entidad = new Pagos()
            {
                Id_factura = factura.Id_factura,
                Fecha = DateTime.Today,
                Valor = 11900m,
                Metodo = "Efectivo"
            };
            this.conexion.Pagos!.Add(this.entidad!);
            this.conexion.SaveChanges();
            Registrar(this.entidad);
        }

        public void Consultar()
        {
            var lista = this.conexion.Pagos!.ToList();
            if (lista.Count <= 0)
                throw new Exception("Lista vacia");
        }

        private void Actualizar()
        {
            this.entidad!.Metodo = "Tarjeta";
            var entry = this.conexion!.Entry<Pagos>(this.entidad!);
            entry.State = EntityState.Modified;
            this.conexion!.SaveChanges();
        }

        private void Borrar()
        {
            this.conexion.Pagos!.Remove(this.entidad!);
            this.conexion.SaveChanges();
        }
    }
}
