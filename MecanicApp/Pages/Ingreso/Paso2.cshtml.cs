using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using TallerMecanica.Data;
using TallerMecanica.Model;

namespace MecanicApp.Pages.Ingreso
{
    public class Paso2Model : PageModel
    {
        private readonly IConfiguration config;

        public IVehiculoService VehiculoService;
        public string Mensaje { get; set; }

        [BindProperty(SupportsGet = true)]
        public string Texto { get; set; }

        [BindProperty(SupportsGet = true)]
        public int Idcliente { get; set; }

        [BindProperty(SupportsGet = true)]
        public string Nombres { get; set; }

        [BindProperty(SupportsGet = true)]
        public string Apellidos { get; set; }

        [TempData]
        public string MensajeEliminacion { get; set; }

        public IList<Vehiculo> Vehiculos { get; set; }

        public Vehiculo Vehiculo { get; set; }

        public Paso2Model(IConfiguration config, IVehiculoService vehiculoService)
        {
            this.config = config;
            VehiculoService = vehiculoService;
        }
        public void OnGet(int Id, string nombre, string apellido)

        {
            this.Idcliente = Id;
            this.Apellidos = apellido;
            this.Nombres = nombre;

            this.Mensaje = config["Mensaje"];

            this.Vehiculos = VehiculoService.GetVehiculosPorMatricula(Texto);
        }
    }
}