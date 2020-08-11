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
    public class Paso3Model : PageModel
    {
        private readonly IConfiguration config;

        public IMecanicoService MecanicoService;
        public string Mensaje { get; set; }

        [BindProperty(SupportsGet = true)]
        public string Texto { get; set; }

        [TempData]
        public string MensajeEliminacion { get; set; }

        [BindProperty(SupportsGet = true)]
        public int Idcliente { get; set; }
        [BindProperty]
        public string Nombres { get; set; }
        [BindProperty]
        public string Apellidos { get; set; }
        [BindProperty]
        public string Matricula { get; set; }
        [BindProperty]
        public string Marca { get; set; }
        [BindProperty]
        public string AnoFab { get; set; }
        [BindProperty]
        public string Color { get; set; }
        [BindProperty]
        public int IdVehiculo { get; set; }

        public IList<Mecanico> Mecanicos { get; set; }

        public Paso3Model(IConfiguration config, IMecanicoService mecanicoService)
        {
            this.config = config;
            MecanicoService = mecanicoService;
        }
        public void OnGet(int Id, int idvehiculo, string nombre, string apellido, string matricula, string marca, string anofab, string color)
        {
            Matricula = matricula;
            Marca = marca;
            AnoFab = anofab;
            Color = color;
            Idcliente = Id;
            Nombres = nombre;
            Apellidos = apellido;
            IdVehiculo = idvehiculo;

            this.Mensaje = config["Mensaje"];

            this.Mecanicos = MecanicoService.GetMecanicosPorNombre(Texto);
        }
    }
}