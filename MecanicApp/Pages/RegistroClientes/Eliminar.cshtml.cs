using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TallerMecanica.Data;
using TallerMecanica.Model;

namespace MecanicApp.Pages.RegistroClientes
{
    public class EliminarModel : PageModel
    {

        private readonly IClienteService service;

        public Cliente Cliente { get; set; }

        public EliminarModel(IClienteService service)
        {
            this.service = service;
        }

        public void OnGet(int Id)
        {
            this.Cliente = service.GetClientePorId(Id);
        }

        public ActionResult OnPost(int Id)
        {
            var cliente = service.Eliminar(Id);
            service.GuardarCambios();

            TempData["MensajeEliminacion"] = $"Se ha eliminado el cliente {cliente.Nombres} {cliente.Apellidos}";

            return RedirectToPage("./RegistroClientes");
        }

    }
}