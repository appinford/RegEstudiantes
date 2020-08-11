using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TallerMecanica.Data;
using TallerMecanica.Model;

namespace MecanicApp.Pages.RegistroMecanicos
{
    public class EliminarModel : PageModel
    {
        private readonly IMecanicoService service;

        public Mecanico Mecanico { get; set; }

        public EliminarModel(IMecanicoService service)
        {
            this.service = service;
        }

        public void OnGet(int Id)
        {
            this.Mecanico = service.GetMecanicoPorId(Id);
        }

        public ActionResult OnPost(int Id)
        {
            var mecanico = service.Eliminar(Id);
            service.GuardarCambios();

            TempData["MensajeEliminacion"] = $"Se ha eliminado el mecánico {mecanico.Nombres} {mecanico.Apellidos}";

            return RedirectToPage("./RegistroMecanicos");
        }
    }
}