using System;
using System.Collections.Generic;
using System.Text;

namespace TallerMecanica.Model
{
    public class VehiculoRep

    {
        int IdOrdenRep { get; set; }
        int IdVehiculo { get; set; }
        int IdMecanico { get; set; }
        string Resolucion { get; set; }
        Estatus Estatus { get; set; }
        string MotivoNoRep { get; set; }
        string DecisionFinal { get; set; }
        DateTime Fecha_Asignacion { get; set; }
        DateTime Fecha_Terminado { get; set; }

    }
}
