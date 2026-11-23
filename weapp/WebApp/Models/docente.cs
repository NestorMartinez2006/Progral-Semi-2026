using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapp.Models
{
    public class Docente
    {
        [Key]
        [Column("idDocentes")]
        public int idDocente { get; set; }

        public string codigo { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }
        public string escalafon { get; set; }
    }
}