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
    public class DetalleVehiculoModel : PageModel
    {
        private readonly IVehiculoService service;
        public Vehiculo Vehiculo { get; set; }

        public IEnumerable<SelectListItem> Marcas { get; set; }
        public IEnumerable<SelectListItem> Color { get; set; }
        public IEnumerable<SelectListItem> LugarFab { get; set; }
        public IEnumerable<SelectListItem> TipoTransmision { get; set; }
        public IEnumerable<SelectListItem> Clientes { get; set; }


        [TempData]
        public string Mensaje { get; set; }

        public DetalleVehiculoModel(IVehiculoService service)
        {
            this.service = service;
        }

        public IActionResult OnGet(int Id)
        {
            Vehiculo = service.GetVehiculosPorId(Id);

            if (Vehiculo == null)
            {
                return RedirectToPage("VehiculoNoEncontrado");
            }
            else
            {
                return Page();
            }
        }
    }
}