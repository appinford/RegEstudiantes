using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TallerMecanica.Data;
using TallerMecanica.Model;

namespace MecanicApp.Pages.RegistroOrdenRep
{
    public class EliminarModel : PageModel
    {
        private readonly IOrdenRepService service;

        public OrdenRep OrdenRep { get; set; }

        public EliminarModel(IOrdenRepService service)
        {
            this.service = service;
        }

        public void OnGet(int Id)
        {
            //this.OrdenRep = service.GetOrdenPorId(Id);
        }

        public ActionResult OnPost(int Id)
        {
            var orden = service.Eliminar(Id);
            service.GuardarCambios();

            TempData["MensajeEliminacion"] = $"Se ha eliminado la orden {orden.Id}";

            return RedirectToPage("./RegistroOrdenRep");
        }
    }
}