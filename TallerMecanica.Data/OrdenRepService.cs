using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TallerMecanica.Model;

namespace TallerMecanica.Data
{
    public class OrdenRepService : IOrdenRepService
    {

        private readonly TallerMecanicaContext db;
        public OrdenRepService(TallerMecanicaContext db)
        {
            this.db = db;
        }

        public OrdenRep ActualizarOrdenRep(OrdenRep ordenActualizada)
        {
            var ordenExistente = db.OrdenReps.SingleOrDefault(m => m.Id == ordenActualizada.Id);

            ordenExistente.Fecha_Asignacion = ordenActualizada.Fecha_Asignacion;
            ordenExistente.Fecha_Terminado = ordenActualizada.Fecha_Terminado;
            ordenExistente.Resolucion = ordenActualizada.Resolucion;
            ordenExistente.Estatus = ordenActualizada.Estatus;
            ordenExistente.MotivoNoRep = ordenActualizada.MotivoNoRep;
            ordenExistente.DecisionFinal = ordenActualizada.DecisionFinal;
            ordenExistente.VehiculoId = ordenActualizada.VehiculoId;
            ordenExistente.MecanicoId = ordenActualizada.MecanicoId;

            return ordenExistente;
        }
        public OrdenRep CrearOrdenRep(OrdenRep orden)
        {
            db.OrdenReps.Add(orden);

            return orden;
        }
        public OrdenRep Eliminar(int id)
        { 
            var orden = db.OrdenReps.Single(m => m.Id == id);
            db.OrdenReps.Remove(orden);

            return orden;
        }

        public IList<OrdenRep> GetOrdenPorMatricula(string texto)
        {
            if (!string.IsNullOrEmpty(texto))
            {
                texto = texto.ToLower();
            }

            return db.OrdenReps.Where(m => string.IsNullOrEmpty(texto) || m.Matricula.ToLower().Contains(texto)).OrderBy(m => m.Matricula).ToList();
        }

        public OrdenRep GetOrdenPorId(int Idcliente, int IdVehiculo, int IdMecanico)
        {
              return db.OrdenReps.SingleOrDefault(d => d.ClienteId == Idcliente );
        }

        public IList<OrdenRep> GetOrdenPorEstatus(int estatus)
        {

            return db.OrdenReps.Where(m => m.Estatus == (Estatus) Enum.Parse(typeof(Estatus), estatus.ToString())).ToList();
            //return db.OrdenReps.Where(m => m.Estatus == estatus).ToList();

        }
        public int GetTotalOrdenesRegistradas()
        {
            return db.OrdenReps.Count();
        }
        public int GuardarCambios()
        {
            return db.SaveChanges();
        }
    }
}
