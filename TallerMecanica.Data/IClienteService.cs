using System;
using System.Collections.Generic;
using System.Text;
using TallerMecanica.Model;

namespace TallerMecanica.Data
{
    public interface IClienteService
    {
        Cliente CrearCliente(Cliente cliente);
        Cliente ActualizarCliente(Cliente clienteActualizado);
        Cliente Eliminar(int id);
        IList<Cliente> GetClientesPorNombre(string texto);

        Cliente GetClientePorId(int Id);
        int GuardarCambios();
        int GetTotalClientesRegistrados();

    }
}
