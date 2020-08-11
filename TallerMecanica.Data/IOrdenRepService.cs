using System;
using System.Collections.Generic;
using System.Text;
using TallerMecanica.Model;

namespace TallerMecanica.Data
{
    public interface IOrdenRepService
    {
        OrdenRep CrearOrdenRep(OrdenRep orden);
        OrdenRep ActualizarOrdenRep(OrdenRep ordenActualizada);
        OrdenRep Eliminar(int id);
        OrdenRep GetOrdenPorId(int Idcliente, int IdVehiculo, int IdMecanico);
        IList<OrdenRep> GetOrdenPorMatricula(string texto);
        IList<OrdenRep> GetOrdenPorEstatus(int estatus);
        int GuardarCambios();
        int GetTotalOrdenesRegistradas();
    }
}
