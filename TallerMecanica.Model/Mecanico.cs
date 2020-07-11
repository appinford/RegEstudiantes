using System;
using System.Collections.Generic;
using System.Text;

namespace TallerMecanica.Model
{
    public class Mecanico
    {
        int IdMecanico { get; set; }
        int IdJefe { get; set; }
        string Nombres { get; set; }
        string Apellidos { get; set; }
        string HabilidadRep { get; set; }
    }
}
