using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using TallerMecanica.Data;
using TallerMecanica.Model;

namespace MecanicApp.Pages.Reporte
{
    public class Reg_ReporteModel : PageModel
    {
        private readonly IConfiguration config;
        private readonly IHtmlHelper helper;

        public IOrdenRepService OrdenService;
        public string Mensaje { get; set; }

        public IEnumerable<SelectListItem> Estatus { get; set; }

        [BindProperty(SupportsGet = true)]
        public string Texto { get; set; }
        private int estatus;

        [TempData]
        public string MensajeEliminacion { get; set; }

        public IList<OrdenRep> OrdenRep { get; set; }

        public OrdenRep OrdenReps { get; set; }

        public Reg_ReporteModel(IConfiguration config, IOrdenRepService ordenService, IHtmlHelper helper)
        {
            this.config = config;
            OrdenService = ordenService;
            this.helper = helper;
        }
        public void OnGet()
        {
            this.Mensaje = config["Mensaje"];
            Estatus = helper.GetEnumSelectList<Estatus>();

                
            if (Texto == null)
            { 
                estatus = 0; 
            }
            else 
            { 
                estatus = Int32.Parse(Texto); 
            }

            this.OrdenRep = OrdenService.GetOrdenPorEstatus(estatus);

        }
    }
}