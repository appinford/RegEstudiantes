using System.ComponentModel.DataAnnotations;

namespace TallerMecanica.Model
{
  
    public enum Estatus
    {
        Pendiente,
        [Display(Name = "En Proceso")]
        En_Proceso,
        Reparado,
        No_Reparado,
        Re_Asignado,
        Entregado
    }
}