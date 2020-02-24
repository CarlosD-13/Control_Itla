using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Control_Itla_Remix.Models
{
    public class Asignatura
    {
        [Key]
        public int AsignaturaID { get; set; }
        [Column(TypeName ="varchar(10)")]
        [Required]
        public string Codigo { get; set; }
        [Column(TypeName ="varchar(30)")]
        public string Nombre { get; set; }
        [Column(TypeName ="int")]
        public int Creditos { get; set; }
    }
}
