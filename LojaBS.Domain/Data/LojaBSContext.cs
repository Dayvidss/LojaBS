using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LojaBS.Domain.Models
{
    public class LojaBSContext : DbContext
    {
        public LojaBSContext (DbContextOptions<LojaBSContext> options)
            : base(options)
        {
        }

        public DbSet<LojaBS.Domain.Models.Cliente> Cliente { get; set; }
    }
}
