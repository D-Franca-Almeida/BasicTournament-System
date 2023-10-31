using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BasicTournament_System.Models;

namespace BasicTournament_System.Data
{
    public class BasicTournament_SystemContext : DbContext
    {
        public BasicTournament_SystemContext (DbContextOptions<BasicTournament_SystemContext> options)
            : base(options)
        {
        }

        public DbSet<BasicTournament_System.Models.Campeonato> Campeonato { get; set; } = default!;
    }
}
