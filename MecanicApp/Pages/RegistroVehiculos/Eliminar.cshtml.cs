using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TallerMecanica.Data;
using TallerMecanica.Model;

namespace MecanicApp.Pages.RegistroVehiculos
{
    public class EliminarModel : PageModel
    {
        private readonly IVehiculoService service;

        public Vehiculo Vehiculo { get; set; }

        public EliminarModel(IVehiculoService service)
        {
            this.service = service;
        }

        public void OnGet(int Id)
        {
            this.Vehiculo = service.GetVehiculosPorId(Id);
        }

        public ActionResult OnPost(int Id)
        {
            var vehiculo = service.EliminarVehiculo(Id);
            service.GuardarCambios();

            TempData["MensajeEliminacion"] = $"Se ha eliminado el vehículo {vehiculo.Id}";

            return RedirectToPage("./RegistroVehiculos");
        }
    }
}