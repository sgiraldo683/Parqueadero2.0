using Aplicacion_Parqueadero.entidades;
using Microsoft.EntityFrameworkCore;

namespace Pruebas_Parqueadero
{
    [TestClass]
    public class VehiculosPruebas : PruebaBase
    {
        private Vehiculos? entidad = null;

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
            var tipo = CrearTipoVehiculo();
            this.entidad = new Vehiculos()
            {
                Placa = Sufijo(6),
                Marca = "Chevrolet",
                Modelo = "Spark",
                Id_tipo = tipo.Id_tipo
            };
            this.conexion.Vehiculos!.Add(this.entidad!);
            this.conexion.SaveChanges();
            Registrar(this.entidad);
        }

        public void Consultar()
        {
            var lista = this.conexion.Vehiculos!.ToList();
            if (lista.Count <= 0)
                throw new Exception("Lista vacia");
        }

        private void Actualizar()
        {
            this.entidad!.Marca = "Renault";
            var entry = this.conexion!.Entry<Vehiculos>(this.entidad!);
            entry.State = EntityState.Modified;
            this.conexion!.SaveChanges();
        }

        private void Borrar()
        {
            this.conexion.Vehiculos!.Remove(this.entidad!);
            this.conexion.SaveChanges();
        }
    }
}
