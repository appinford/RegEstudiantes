using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using TallerMecanica.Data;
using TallerMecanica.Model;

namespace MecanicApp.Pages.RegistroOrdenRep
{
    [Authorize(Roles = "Admin")]
    public class RegistroOrdenRepModel : PageModel
    {
        private readonly IConfiguration config;

        public IOrdenRepService OrdenService;
        public string Mensaje { get; set; }

        public IEnumerable<SelectListItem> Estatus { get; set; }

        [BindProperty(SupportsGet = true)]
        public string Texto { get; set; }

        [TempData]
        public string MensajeEliminacion { get; set; }

        public IList<OrdenRep> OrdenRep { get; set; }

        public OrdenRep  OrdenReps { get; set; }

        public RegistroOrdenRepModel(IConfiguration config, IOrdenRepService ordenService)
        {
            this.config = config;
            OrdenService = ordenService;
        }
        public void OnGet()
        {
            this.Mensaje = config["Mensaje"];

            this.OrdenRep = OrdenService.GetOrdenPorMatricula(Texto);
        }
    }
}