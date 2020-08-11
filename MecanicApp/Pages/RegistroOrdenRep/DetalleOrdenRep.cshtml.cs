using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using TallerMecanica.Data;
using TallerMecanica.Model;

namespace MecanicApp.Pages.RegistroOrdenRep
{
    public class DetalleOrdenRepModel : PageModel
    {
        private readonly IOrdenRepService service;
        public OrdenRep OrdenRep { get; set; }

        public IEnumerable<SelectListItem> Vehiculos { get; set; }
        public IEnumerable<SelectListItem> Mecanicos { get; set; }
        public IEnumerable<SelectListItem> Estatus { get; set; }
        public IEnumerable<SelectListItem> Clientes { get; set; }

        [TempData]
        public string Mensaje { get; set; }

        public DetalleOrdenRepModel(IOrdenRepService service)
        {
            this.service = service;
        }

        public IActionResult OnGet(int Id)
        {
            //OrdenRep = service.GetOrdenPorId(Id);

            //if (OrdenRep == null)
            //{
            //    return RedirectToPage("VehiculoNoEncontrado");
            //}
            //else
            //{
                return Page();
            //}
        }
    }
}