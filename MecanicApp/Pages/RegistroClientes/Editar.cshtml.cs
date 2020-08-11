using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using TallerMecanica.Data;
using TallerMecanica.Model;

namespace MecanicApp.Pages.RegistroClientes
{
    public class EditarModel : PageModel
    {
        private readonly IClienteService service;
        private readonly IHtmlHelper helper;

        [BindProperty]
        public Cliente Cliente { get; set; }

        public IEnumerable<SelectListItem> Clientes { get; set; }

        public EditarModel(IClienteService service, IHtmlHelper helper)
        {
            this.service = service;
            this.helper = helper;
        }

        public void OnGet(int? Id)
        {
           // Clientes = helper.GetEnumSelectList<Cliente>();

            if (Id.HasValue)
            {
                Cliente = service.GetClientePorId(Id.Value);
            }
            else
            {
                Cliente = new Cliente();
            }
        }

        public ActionResult OnPost()
        {
            //Clientes = helper.GetEnumSelectList<Cliente>();

            if (ModelState.IsValid)
            {
                if (Cliente.Id == 0)
                {
                    Cliente = service.CrearCliente(Cliente);
                    TempData["Mensaje"] = "Registro Creado Correctamente";
                }
                else
                {
                    Cliente = service.ActualizarCliente(Cliente);
                    TempData["Mensaje"] = "Registro Actualizado Correctamente";
                }

                service.GuardarCambios();

                return RedirectToPage("./DetalleCliente", new { Id = Cliente.Id });
            }

            return Page();
        }
    }
}