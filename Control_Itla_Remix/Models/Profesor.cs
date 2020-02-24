using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Control_Itla_Remix.Models
{
    public class Profesor
    {
        [Key]
        public int ProfesorID { get; set; }
        [Column(TypeName = "varchar(30)")]
        [Required]
        public string Nombre { get; set; }
        [Column(TypeName = "varchar(30)")]
        public string Area { get; set; }
        [Column(TypeName = "varchar(30)")]
        public string Genero { get; set; }
    }
}
