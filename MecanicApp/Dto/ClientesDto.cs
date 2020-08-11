using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MecanicApp.Dto
{
    public class ClientesDto
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public int CantidadDeVehiculos { get; set; }
    }
}
