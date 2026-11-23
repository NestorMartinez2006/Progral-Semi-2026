using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models
{
    [Table("materias")]
    public class Materia
    {
        [Key]
        [Column("idMateria")]
        public int idMateria { get; set; }
        public int codigo { get; set; }
        public string nombre { get; set; } = string.Empty;
        public int uv { get; set; }

    }
}