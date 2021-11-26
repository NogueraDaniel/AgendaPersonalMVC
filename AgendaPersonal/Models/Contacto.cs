using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgendaPersonal.Models
{
    public class Contacto
    {
       [Key]
       [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idContacto;

  
        public string Nombre;

   
        public string Apellido;

        [Display(Name = "Correo/s electronico/s")]
        public string[] emails;

        [Display(Name = "Telefono/s")]
        public int[] telefonos;

        public string Direccion;

        [EnumDataType(typeof(Tipo))]
        public Tipo tipoContacto;

    }
}
