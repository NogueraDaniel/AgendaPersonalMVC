using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgendaPersonal.Models
{
    public class Contacto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idContacto { get; set; }

        [Required(ErrorMessage = "Ingrese un nombre válido")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Ingrese un apellido válido")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "Ingrese un email válido")]
        [EmailAddress(ErrorMessage = "Ingrese un email válido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Ingrese un telefono válido")]
        public int Telefono { get; set; }

        [Required(ErrorMessage = "Ingrese una direccion válida")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "Defina el tipo de contacto")]
        [EnumDataType(typeof(Tipo))]
        [Display(Name = "Tipo de contacto")]
        public Tipo tipoContacto { get; set; }

    }
}
