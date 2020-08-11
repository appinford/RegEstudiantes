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
    public class EditarModel : PageModel
    {
        private readonly IOrdenRepService service;
        private readonly IHtmlHelper helper;

        [BindProperty]
        public OrdenRep OrdenRep { get; set; }

        public IEnumerable<SelectListItem> Estatus { get; set; }

        [BindProperty(SupportsGet = true)]
        public int Idcliente { get; set; }
        [BindProperty]
        public string Nombres { get; set; }
        [BindProperty]
        public string Apellidos { get; set; }
        [BindProperty]
        public string Matricula { get; set; }
        [BindProperty]
        public string Marca1 { get; set; }
        [BindProperty]
        public string AnoFab { get; set; }
        [BindProperty]
        public string Color1 { get; set; }
        [BindProperty]
        public int IdVehiculo { get; set; }

        [BindProperty]
        public int IdMecanico { get; set; }
        [BindProperty]
        public string NomMecanico { get; set; }
        [BindProperty]
        public string ApeMecanico { get; set; }

        public EditarModel(IOrdenRepService service, IHtmlHelper helper)
        {
            this.service = service;
            this.helper = helper;
        }


        public void OnGet(int? Id, int mecid, string mecnombre, string mecapellido, int idcliente, int idvehiculo, string nombre, string apellido, string matricula, string marca, string anofab, string color)
        {
            Matricula = matricula;
            Marca1 = marca;
            AnoFab = anofab;
            Color1 = color;
            Idcliente = idcliente;
            Nombres = nombre;
            Apellidos = apellido;
            IdVehiculo = idvehiculo;
            NomMecanico = mecnombre;
            ApeMecanico = mecapellido;
            IdMecanico = mecid;

            Estatus = helper.GetEnumSelectList<Estatus>();


            if ( (Idcliente > 0) && (IdVehiculo > 0) && (IdMecanico > 0 ))
            {
                OrdenRep = service.GetOrdenPorId(Idcliente, IdVehiculo, IdMecanico);
            }
            else
            {
                OrdenRep = new OrdenRep();
            }

        }


        public ActionResult OnPost()
        {

            if (ModelState.IsValid)
            {
                //if (OrdenRep.Id == 0)
                //{
                //    OrdenRep = service.CrearOrdenRep(OrdenRep);
                //    TempData["Mensaje"] = "Registro Creado Correctamente";
                //}
                //else
                //{
                    OrdenRep = service.ActualizarOrdenRep(OrdenRep);
                    TempData["Mensaje"] = "Registro Actualizado Correctamente";
                //}

                service.GuardarCambios();

                return RedirectToPage("./RegistroOrdenRep");
            }

            return Page();
        }
    }
}