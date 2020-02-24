using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Control_Itla_Remix.Models
{
    public class ProfesorContext :DbContext
    {
        public ProfesorContext(DbContextOptions<ProfesorContext> options): base(options)
        {       
        }

        public DbSet<Profesor> Profesors { get; set; }
    }
}
