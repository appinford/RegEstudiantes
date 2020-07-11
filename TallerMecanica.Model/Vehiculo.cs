using System;
using System.Collections.Generic;
using System.Text;

namespace TallerMecanica.Model
{
    public class Vehiculo
    {
        int IdVehiculo { get; set; }
        int IdCliente { get; set; }
        int IdOrdenRep { get; set; }
        DateTime FechaIngreso { get; set; }
        DateTime FechaEntrega { get; set; }
        string DescProblema { get; set; }
        string Comentario { get; set; }
        Marca Marca { get; set; }
        int AnoFab { get; set; }
        Color Color { get; set; }
        TipoTransmision TipoTransmision { get; set; }
        LugarFab LugarFab { get; set; }
        CiaSeguros CiaSeguros { get; set; }
    }

 
}
