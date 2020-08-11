using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using TallerMecanica.Data;
using TallerMecanica.Model;

namespace MecanicApp.Pages.RegistroMecanicos
{
    [Authorize(Roles = "Super")]
    public class RegistroMecanicosModel : PageModel
    {
        private readonly IConfiguration config;

        public IMecanicoService MecanicoService;
        public string Mensaje { get; set; }

        [BindProperty(SupportsGet = true)]
        public string Texto { get; set; }

        [TempData]
        public string MensajeEliminacion { get; set; }

  
        public IList<Mecanico> Mecanicos { get; set; }

        public RegistroMecanicosModel(IConfiguration config, IMecanicoService mecanicoService)
        {
            this.config = config;
            MecanicoService = mecanicoService;
        }
        public void OnGet()
        {

            this.Mensaje = config["Mensaje"];

            this.Mecanicos = MecanicoService.GetMecanicosPorNombre(Texto);
        }
    }
}