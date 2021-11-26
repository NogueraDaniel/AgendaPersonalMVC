using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgendaPersonal.Models
{
    public class Contacto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idContacto { get; set; }


        public string Nombre { get; set; }


        public string Apellido { get; set; }


        public string Email { get; set; }

        public int telefono { get; set; }

        public string Direccion { get; set; }

        [EnumDataType(typeof(Tipo))]
        public Tipo tipoContacto { get; set; }

    }
}
