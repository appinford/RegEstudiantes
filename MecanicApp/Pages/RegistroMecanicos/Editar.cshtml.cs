using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using TallerMecanica.Data;
using TallerMecanica.Model;

namespace MecanicApp.Pages.RegistroMecanicos
{
    public class EditarModel : PageModel
    {
        private readonly IMecanicoService service;
        private readonly IHtmlHelper helper;

        [BindProperty]
        public Mecanico Mecanico { get; set; }

        public IEnumerable<SelectListItem> Mecanicos { get; set; }

        public EditarModel(IMecanicoService service, IHtmlHelper helper)
        {
            this.service = service;
            this.helper = helper;
        }

        public void OnGet(int? Id)
        {
            // Mecanicos = helper.GetEnumSelectList<Mecanico>();

            if (Id.HasValue)
            {
                Mecanico = service.GetMecanicoPorId(Id.Value);
            }
            else
            {
                Mecanico = new Mecanico();
            }
        }

        public ActionResult OnPost()
        {
            //Mecanicos = helper.GetEnumSelectList<Mecanico>();

            if (ModelState.IsValid)
            {
                if (Mecanico.Id == 0)
                {
                    Mecanico = service.CrearMecanico(Mecanico);
                    TempData["Mensaje"] = "Registro Creado Correctamente";
                }
                else
                {
                    Mecanico = service.ActualizarMecanico(Mecanico);
                    TempData["Mensaje"] = "Registro Actualizado Correctamente";
                }

                service.GuardarCambios();

                return RedirectToPage("./DetalleMecanico", new { Id = Mecanico.Id });
            }

            return Page();
        }
    }
}