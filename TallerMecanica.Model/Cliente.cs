using System;
using System.Collections.Generic;
using System.Text;

namespace TallerMecanica.Model
{
    public class Cliente
    {
        int IdCliente { get; set; }
        string Nombre { get; set; }
        string Apellidos { get; set; }
        string Cedula { get; set; }
        string Direccion { get; set; }
        string Sector { get; set; }
        string Ciudad { get; set; }
    }
}
