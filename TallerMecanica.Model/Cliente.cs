using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TallerMecanica.Model
{
    public class Cliente
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Debe ingresar el nombre del cliente.")]
        [StringLength(50)]
        public string Nombres { get; set; }

        [Required(ErrorMessage = "Debe ingresar los apellidos del cliente.")]
        [StringLength(50)]
        public string Apellidos { get; set; }

        [Required(ErrorMessage = "Debe ingresar la cédula de identidad del cliente.")]
        [StringLength(50)]
        [MinLength(11)]
        [MaxLength(11)]
        [DisplayFormat(DataFormatString = "{0:###-#######-#}", ApplyFormatInEditMode = true)]
        [Display(Name = "Cédula")]
        public string Cedula { get; set; }

        [Required(ErrorMessage = "Debe ingresar la dirección del cliente.")]
        [StringLength(80)]
        [Display(Name = "Dirección")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "Debe ingresar el sector donde vive el cliente.")]
        [StringLength(50)]
        public string Sector { get; set; }

        [Required(ErrorMessage = "Debe especificar la ciudad donde vive el cliente.")]
        [StringLength(50)]
        public string Ciudad { get; set; }

         public ICollection<OrdenRep> OrdenReps { get; set; }

    }
}
