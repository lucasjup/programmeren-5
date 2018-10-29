using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Awen.Models;
using Awen.Areas.Identity.Data;

namespace Awen.Data
{
    public class ApplicationDbContext : IdentityDbContext<AwenUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Awen.Models.Course> Course { get; set; }
    }
}
