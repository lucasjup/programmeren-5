using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace programmeren_5.Models
{
    public class programmeren_5Context : DbContext
    {
        public programmeren_5Context (DbContextOptions<programmeren_5Context> options)
            : base(options)
        {
        }

        public DbSet<programmeren_5.Models.Ad> Ad { get; set; }
    }
}
