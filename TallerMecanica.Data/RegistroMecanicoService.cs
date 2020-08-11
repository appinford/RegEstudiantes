using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TallerMecanica.Model;

namespace TallerMecanica.Data
{
    public class RegistroMecanicoService : IMecanicoService
    {
        private readonly TallerMecanicaContext db;
        public RegistroMecanicoService(TallerMecanicaContext db)
        {
            this.db = db;
        }
        public Mecanico ActualizarMecanico(Mecanico mecanicoActualizado)
        {
            var mecanicoExistente = db.Mecanicos.SingleOrDefault(m => m.Id == mecanicoActualizado.Id);

            mecanicoExistente.Nombres = mecanicoActualizado.Nombres;
            mecanicoExistente.Apellidos = mecanicoActualizado.Apellidos;
            mecanicoExistente.HabilidadRep = mecanicoActualizado.HabilidadRep;

            return mecanicoExistente;
        }
        public Mecanico CrearMecanico(Mecanico mecanico)
        {
            db.Mecanicos.Add(mecanico);

            return mecanico;
        }
        public Mecanico Eliminar(int id)
        {
            var mecanico = db.Mecanicos.Single(m => m.Id == id);
            db.Mecanicos.Remove(mecanico);

            return mecanico;
        }
        public Mecanico GetMecanicoPorId(int Id)
        {
            return db.Mecanicos.SingleOrDefault(d => d.Id == Id);
        }
        public int GetTotalMecanicosRegistrados()
        {
            return db.Mecanicos.Count();
        }
        public IList<Mecanico> GetMecanicosPorNombre(string texto)
        {
            if (!string.IsNullOrEmpty(texto))
            {
                texto = texto.ToLower();
            }

            return db.Mecanicos.Where(m => string.IsNullOrEmpty(texto) || m.Nombres.ToLower().Contains(texto)).OrderBy(m => m.Nombres).ToList();

        }
        public int GuardarCambios()
        {
            return db.SaveChanges();
        }
    }
}
