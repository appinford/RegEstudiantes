using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TallerMecanica.Model
{
    public class Mecanico
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Debe ingresar el nombre del mecánico.")]
        [StringLength(50)]
        public string Nombres { get; set; }

        [Required(ErrorMessage = "Debe ingresar los apellidos del mecánico.")]
        [StringLength(50)]
        public string Apellidos { get; set; }

        [Required(ErrorMessage = "Debe ingresar Habilidades de reparación del mecánico.")]
        [StringLength(250)]
        public string HabilidadRep { get; set; }

        public ICollection<OrdenRep> OrdenReps { get; set; }
    }
}
