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
    public class DetalleMecanicoModel : PageModel
    {
        private readonly IMecanicoService service;
        public Mecanico Mecanico { get; set; }

        [TempData]
        public string Mensaje { get; set; }

        public DetalleMecanicoModel(IMecanicoService service)
        {
            this.service = service;
        }

        public IActionResult OnGet(int Id)
        {
            Mecanico = service.GetMecanicoPorId(Id);

            if (Mecanico == null)
            {
                return RedirectToPage("MecanicoNoEncontrado");
            }
            else
            {
                return Page();
            }
        }
    }
}