using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using TallerMecanica.Data;
using TallerMecanica.Model;

namespace MecanicApp.Pages.Ingreso
{
    public class Paso1Model : PageModel
    {
        private readonly IConfiguration config;

        public IClienteService ClienteService;
        public string Mensaje { get; set; }

        [BindProperty(SupportsGet = true)]
        public string Texto { get; set; }

        [TempData]
        public string MensajeEliminacion { get; set; }

        public IList<Cliente> Clientes { get; set; }

        public Paso1Model(IConfiguration config, IClienteService clienteService)
        {
            this.config = config;
            ClienteService = clienteService;
        }
        public void OnGet()
        {
            this.Mensaje = config["Mensaje"];

            this.Clientes = ClienteService.GetClientesPorNombre(Texto);
        }
    }
}