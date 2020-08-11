using System;
using System.Collections.Generic;
using System.Text;
using TallerMecanica.Model;

namespace TallerMecanica.Data
{
    public interface IMecanicoService
    {
        Mecanico CrearMecanico(Mecanico mecanico);
        Mecanico ActualizarMecanico(Mecanico mecanicoActualizado);
        Mecanico Eliminar(int id);
        IList<Mecanico> GetMecanicosPorNombre(string texto);

        Mecanico GetMecanicoPorId(int Id);
        int GuardarCambios();
        int GetTotalMecanicosRegistrados();
    }
}
