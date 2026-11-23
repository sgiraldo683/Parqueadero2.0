using Aplicacion_Parqueadero.entidades;
using Aplicacion_Parqueadero.interfaces;
using Aplicacion_Parqueadero.nucleo;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace front_Parqueadero.Pages.Ventanas
{
    public class Tipos_TrabajadoresModel : PageModel
    {
        private ITipos_TrabajadoresPresentacion ITipos_TrabajadoresPresentacion;

        public Tipos_TrabajadoresModel(ITipos_TrabajadoresPresentacion ITipos_TrabajadoresPresentacion)
        {
            this.ITipos_TrabajadoresPresentacion = ITipos_TrabajadoresPresentacion;
            this.Filtro = new Tipos_Trabajadores();
        }

        [BindProperty] public List<Tipos_Trabajadores> Lista { get; set; }
        [BindProperty] public Tipos_Trabajadores? Filtro { get; set; }
        [BindProperty] public Tipos_Trabajadores? Actual { get; set; }
        [BindProperty] public bool Formulario { get; set; } = false;
        [BindProperty] public bool Borrar { get; set; } = false;
        
        public void OnGet() { OnPostBtConsultar(); }

        public void OnPostBtConsultar()
        {
            try
            {
                Filtro!.Nombre = Filtro!.Nombre ?? "";
                Lista = this.ITipos_TrabajadoresPresentacion.Buscar(Filtro!);
            }
            catch (Exception ex)
            {
                LogConversor.Log(ex, ViewData!);
            }
        }

        public void OnPostBtNuevo()
        {
            try
            {
                Formulario = true;
                this.Actual = new Roles();
            }
            catch (Exception ex)
            {
                LogConversor.Log(ex, ViewData!);
            }
        }

        public void OnPostBtGuardar()
        {
            try
            {
                if (this.Actual!.Id == 0)
                    this.Actual = this.ITipos_TrabajadoresPresentacion.Insertar(this.Actual!);
                else
                    this.Actual = this.ITipos_TrabajadoresPresentacion.Actualizar(this.Actual!);
            }
            catch (Exception ex)
            {
                LogConversor.Log(ex, ViewData!);
            }
            finally
            {
                OnPostBtConsultar();
            }
        }

        public void OnPostBtEditar(string data)
        {
            try
            {
                Formulario = true;
                OnPostBtConsultar();
                this.Actual = this.Lista.FirstOrDefault(x => x.Id == Convert.ToInt32(data));
            }
            catch (Exception ex)
            {
                LogConversor.Log(ex, ViewData!);
            }
        }

        public void OnPostBtPregBorrar(string data)
        {
            try
            {
                Borrar = true;
                OnPostBtConsultar();
                this.Actual = this.Lista.FirstOrDefault(x => x.Id == Convert.ToInt32(data));
            }
            catch (Exception ex)
            {
                LogConversor.Log(ex, ViewData!);
            }
        }

        public void OnPostBtBorrar()
        {
            try
            {
                if (this.Actual!.Id == 0)
                    return;
                this.Actual = this.ITipos_TrabajadoresPresentacion.Borrar(this.Actual!);
            }
            catch (Exception ex)
            {
                LogConversor.Log(ex, ViewData!);
            }
            finally
            {
                OnPostBtConsultar();
            }
        }
    }
}
