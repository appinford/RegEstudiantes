using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TallerMecanica.Model
{
    public class OrdenRep

    {
        public int Id { get; set; }

        [StringLength(15)]
        [Display(Name = "Numero de Orden")]
        public string NumeroOrden { get; set; }

        [Required(ErrorMessage = "Debe ingresar el nombre del cliente.")]
        [StringLength(50)]
        public string Cliente_Nombres { get; set; }

        [Required(ErrorMessage = "Debe ingresar los apellidos del cliente.")]
        [StringLength(50)]
        public string Cliente_Apellidos { get; set; }

        [Required(ErrorMessage = "Debe ingresar el nombre del mecánico.")]
        [StringLength(50)]
        public string Mecanico_Nombres { get; set; }

        [Required(ErrorMessage = "Debe ingresar los apellidos del mecánico.")]
        [StringLength(50)]
        public string Mecanico_Apellidos { get; set; }

        [Required(ErrorMessage = "Debe especificar una marca.")]
        public Marca Marca { get; set; }

        [Required(ErrorMessage = "Debe especificar una matrícula.")]
        public string Matricula { get; set; }

        [Required(ErrorMessage = "Debe ingresar el año de fabricación.")]
        [Display(Name = "Año de Fabricación")]
        public int AnoFab { get; set; }

        [Required(ErrorMessage = "Debe especificar el color del vehículo.")]
        public Color Color { get; set; }

        //[Required(ErrorMessage = "Debe ingresar la fecha en que ingresa el vehículo.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Fecha de Ingreso")]
        public DateTime Fecha_Asignacion { get; set; }

        //[Required(ErrorMessage = "Debe ingresar la fecha en que finaliza el trabajo con el vehículo.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Fecha de Compromiso")]
        public DateTime Fecha_Terminado { get; set; }

        //[Required(ErrorMessage = "Debe ingresar ls resolución del problema.")]
        [StringLength(250)]
        [Display(Name = "Resolución del Problema")]
        public string Resolucion { get; set; }

        [Required(ErrorMessage = "Debe especificar el Estatus de la Orden.")]
        public Estatus Estatus { get; set; }

        [StringLength(250)]
        [Display(Name = "Motivo de No Reparado")]
        public string MotivoNoRep { get; set; }

        //[Required(ErrorMessage = "Debe ingresar la decisión final.")]
        [StringLength(250)]
        [Display(Name = "Decisión Final")]
        public string DecisionFinal { get; set; }

        public int VehiculoId { get; set; }
        public Vehiculo Vehiculo {get; set;}

        public int MecanicoId { get; set; }
        public Mecanico Mecanico { get; set; }

        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }



    }
}
