using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Control_Itla_Remix.Models
{
    public class Estudiante
    {
        [Key]
        public int EstudianteID { get; set; }
        [Column(TypeName ="varchar(10)")]
        [Required]
        public  string Matricula { get; set; }
        [Column(TypeName ="varchar(30)")]
        public string Nombre { get; set; }
        [Column(TypeName ="varchar(2)")]
        public string Genero { get; set; }
        [Column(TypeName ="int")]
        public int  Edad { get; set; }
    }
}
