using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Control_Itla_Remix.Models
{
    public class AsignaturaContext : DbContext
    {
        public AsignaturaContext(DbContextOptions<AsignaturaContext> options) : base(options)
        {
        }

        public DbSet<Asignatura> Asignaturas { get; set; }
    }
}
