using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TallerMecanica.Model;

namespace TallerMecanica.Data
{
    public class RegistroVehiculoService : IVehiculoService
    {

        private readonly TallerMecanicaContext db;
        public RegistroVehiculoService(TallerMecanicaContext db)
        {
            this.db = db;
        }
        public Vehiculo ActualizarVehiculo(Vehiculo vehiculoActualizado)
        {
            var vehiculoExistente = db.Vehiculos.SingleOrDefault(m => m.Id == vehiculoActualizado.Id);

            vehiculoExistente.Marca = vehiculoActualizado.Marca;
            vehiculoExistente.AnoFab = vehiculoActualizado.AnoFab;
            vehiculoExistente.Color = vehiculoActualizado.Color;
            vehiculoExistente.TipoTransmision = vehiculoActualizado.TipoTransmision;
            vehiculoExistente.LugarFab = vehiculoActualizado.LugarFab; 
            vehiculoExistente.DescProblema = vehiculoActualizado.DescProblema;
            vehiculoExistente.Comentario = vehiculoActualizado.Comentario;
            vehiculoExistente.FechaIngreso = vehiculoActualizado.FechaIngreso;
            vehiculoExistente.FechaEntrega = vehiculoActualizado.FechaEntrega;


            return vehiculoExistente;
        }
        public Vehiculo CrearVehiculo(Vehiculo vehiculo)
        {
            db.Vehiculos.Add(vehiculo);

            return vehiculo;
        }
        public Vehiculo EliminarVehiculo(int id)
        {
            var vehiculo = db.Vehiculos.Single(m => m.Id == id);
            db.Vehiculos.Remove(vehiculo);

            return vehiculo;
        }

        public IList<Vehiculo> GetVehiculosPorMatricula(string texto)
        {
            if (!string.IsNullOrEmpty(texto))
            {
                texto = texto.ToLower();
            }

            return db.Vehiculos.Where(m => string.IsNullOrEmpty(texto) || m.Matricula.ToLower().Contains(texto)).OrderBy(m => m.Matricula).ToList();
        }
        public int GetTotalVehiculosRegistrados()
        {
            return db.Vehiculos.Count();
        }
        public Vehiculo GetVehiculosPorId(int Id)
        {
            return db.Vehiculos.SingleOrDefault(d => d.Id == Id);
        }
        public int GuardarCambios()
        {
            return db.SaveChanges();
        }
    }
}
