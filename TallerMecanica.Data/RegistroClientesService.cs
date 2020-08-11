using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TallerMecanica.Model;

namespace TallerMecanica.Data
{
    public class RegistroClientesService : IClienteService
    {
        private readonly TallerMecanicaContext db;
        public RegistroClientesService(TallerMecanicaContext db)
        {
            this.db = db;
        }
        public Cliente ActualizarCliente(Cliente clienteActualizado)
        {
            var clienteExistente = db.Clientes.SingleOrDefault(m => m.Id == clienteActualizado.Id);

            clienteExistente.Nombres = clienteActualizado.Nombres;
            clienteExistente.Apellidos = clienteActualizado.Apellidos;
            clienteExistente.Cedula = clienteActualizado.Cedula;
            clienteExistente.Direccion = clienteActualizado.Direccion;
            clienteExistente.Sector = clienteActualizado.Sector;
            clienteExistente.Ciudad = clienteActualizado.Ciudad;

            return clienteExistente;
        }
        public Cliente CrearCliente(Cliente cliente)
        {
            db.Clientes.Add(cliente);

            return cliente;
        }
        public Cliente Eliminar(int id)
        {
            var cliente = db.Clientes.Single(m => m.Id == id);
            db.Clientes.Remove(cliente);

            return cliente;
        }
        public Cliente GetClientePorId(int Id)
        {
            return db.Clientes.SingleOrDefault(d => d.Id == Id);
        }
        public IList<Cliente> GetClientesPorNombre(string texto)
        {
            if (!string.IsNullOrEmpty(texto))
            {
                texto = texto.ToLower();
            }

            return db.Clientes.Where(m => string.IsNullOrEmpty(texto) || m.Nombres.ToLower().Contains(texto)).OrderBy(m => m.Nombres).ToList();
        }
        public int GetTotalClientesRegistrados()
        {
            return db.Clientes.Count();
        }
        public int GuardarCambios()
        {
            return db.SaveChanges();

        }
         
    }
}
