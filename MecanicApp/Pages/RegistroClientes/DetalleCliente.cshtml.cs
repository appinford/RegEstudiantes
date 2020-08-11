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
    public class DetalleClienteModel : PageModel
    {
        private readonly IClienteService service;
        public Cliente Cliente { get; set; }

        [TempData]
        public string Mensaje { get; set; }

        public DetalleClienteModel(IClienteService service)
        {
            this.service = service;
        }

        public IActionResult OnGet(int Id)
        {
            Cliente = service.GetClientePorId(Id);

            if (Cliente == null)
            {
                return RedirectToPage("ClienteNoEncontrado");
            }
            else
            {
                return Page();
            }
        }
    }
}