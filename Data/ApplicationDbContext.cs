using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyCityPlan_Demo.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCityPlan_Demo.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Benutzer> Benutzer { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
