using System;
using System.Collections.Generic;
using System.Text;
using TallerMecanica.Model;

namespace TallerMecanica.Data
{
    public interface IVehiculoService
    {

        Vehiculo CrearVehiculo(Vehiculo vehiculo);
        Vehiculo ActualizarVehiculo(Vehiculo vehiculoActualizado);
        Vehiculo EliminarVehiculo(int id);

        IList<Vehiculo> GetVehiculosPorMatricula(string texto);

        Vehiculo GetVehiculosPorId(int Id);
        int GuardarCambios();
        int GetTotalVehiculosRegistrados();
    }
}
