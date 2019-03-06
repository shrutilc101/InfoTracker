using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using InfoTracker.Models;

namespace InfoTracker.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        internal object IT;

        public DbSet<IT> ITs { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
