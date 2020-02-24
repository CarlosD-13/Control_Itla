using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Control_Itla_Remix.Models;

namespace Control_Itla_Remix.Models
{
    public class EstudianteContext : DbContext
    {
        public EstudianteContext(DbContextOptions<EstudianteContext> options):base(options)
        {
        }

        public  DbSet<Estudiante> Estudiantes { get; set; }

        public DbSet<Control_Itla_Remix.Models.Profesor> Profesor { get; set; }
    }
}
