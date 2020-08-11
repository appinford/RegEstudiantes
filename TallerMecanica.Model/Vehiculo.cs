using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TallerMecanica.Model
{
    public class Vehiculo
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Debe especificar una marca.")]
        public Marca Marca { get; set; }

        [Required(ErrorMessage = "Debe especificar una matrícula.")]
        public string Matricula { get; set; }

        [Required(ErrorMessage = "Debe ingresar el año de fabricación.")]
        [Display(Name = "Año de Fabricación")]
        public int AnoFab { get; set; }

        [Required(ErrorMessage = "Debe especificar el color del vehículo.")]
        public Color Color { get; set; }

        [Required(ErrorMessage = "Debe especificar el tipo de transmisión.")]
        [Display(Name = "Tipo de Transmisión")]
        public TipoTransmision TipoTransmision { get; set; }

        [Required(ErrorMessage = "Debe ingresar el lugar de fabricación.")]
        [Display(Name = "Lugar de Fabricación")]
        public LugarFab LugarFab { get; set; }

        [Required(ErrorMessage = "Debe ingresar una descripción del problema.")]
        [StringLength(150)]
        [Display(Name = "Descripción del Problema")]
        public string DescProblema { get; set; }

        [StringLength(250)]
        [Display(Name = "Comentario")]
        public string Comentario { get; set; }

        [Required(ErrorMessage = "Debe ingresar la fecha en que ingresa el vehículo.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Fecha de Ingreso")]
        public DateTime FechaIngreso { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Fecha de Entrega")]
        public DateTime FechaEntrega { get; set; }

         public ICollection<OrdenRep> OrdenReps { get;  set; }
    }

 
}
