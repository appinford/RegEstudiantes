using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using TallerMecanica.Data;
using TallerMecanica.Model;

namespace MecanicApp.Pages.RegistroOrdenRep
{
    public class BuscarVehiculoModel : PageModel
    {
        private readonly IConfiguration config;

        public IVehiculoService VehiculoService;
        public string Mensaje { get; set; }

        [BindProperty(SupportsGet = true)]
        public string Texto { get; set; }

        [TempData]
        public string MensajeEliminacion { get; set; }

        public IList<Vehiculo> Vehiculos { get; set; }

        public Vehiculo Vehiculo { get; set; }

        public BuscarVehiculoModel(IConfiguration config, IVehiculoService vehiculoService)
        {
            this.config = config;
            VehiculoService = vehiculoService;
        }
        public void OnGet()
        {
            this.Mensaje = config["Mensaje"];

            this.Vehiculos = VehiculoService.GetVehiculosPorMatricula(Texto);
        }
    }
}