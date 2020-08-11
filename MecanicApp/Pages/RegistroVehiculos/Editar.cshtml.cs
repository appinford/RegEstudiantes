using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using TallerMecanica.Data;
using TallerMecanica.Model;

namespace MecanicApp.Pages.RegistroVehiculos
{
    public class EditarModel : PageModel
    {
        private readonly IVehiculoService service;
        private readonly IHtmlHelper helper;

        [BindProperty]
        public Vehiculo Vehiculo { get; set; }

        public IEnumerable<SelectListItem> Marcas { get; set; }
        public IEnumerable<SelectListItem> Color { get; set; }
        public IEnumerable<SelectListItem> LugarFab { get; set; }
        public IEnumerable<SelectListItem> TipoTransmision { get; set; }


        public IList<Cliente> Clientes { get; set; }
        public SelectList ListaDeClientes { get; set; }

        public EditarModel(IVehiculoService service, IHtmlHelper helper)
        {
            this.service = service;
            this.helper = helper;
        }

        public void OnGet(int? Id)
        {
            Marcas = helper.GetEnumSelectList<Marca>();
            LugarFab = helper.GetEnumSelectList<LugarFab>();
            TipoTransmision = helper.GetEnumSelectList<TipoTransmision>();
            Color = helper.GetEnumSelectList<Color>();

            if (Id.HasValue)
            {
                Vehiculo = service.GetVehiculosPorId(Id.Value);
            }
            else
            {
                Vehiculo = new Vehiculo();
            }
        }

        public ActionResult OnPost()
        {

            Marcas = helper.GetEnumSelectList<Marca>();
            LugarFab = helper.GetEnumSelectList<LugarFab>();
            TipoTransmision = helper.GetEnumSelectList<TipoTransmision>();
            Color = helper.GetEnumSelectList<Color>();

            if (ModelState.IsValid)
            {
                if (Vehiculo.Id == 0)
                {
                    Vehiculo = service.CrearVehiculo(Vehiculo);
                    TempData["Mensaje"] = "Registro Creado Correctamente";
                }
                else
                {
                    Vehiculo = service.ActualizarVehiculo(Vehiculo);
                    TempData["Mensaje"] = "Registro Actualizado Correctamente";
                }

                service.GuardarCambios();

                return RedirectToPage("./DetalleVehiculo", new { Id = Vehiculo.Id });
            }

            return Page();
        }
    }
}