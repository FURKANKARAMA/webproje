using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using webproje2021.Models;

namespace webproje2021.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<admin> admin { get; set; }
        public DbSet<kullanici> kullanici { get; set; }
        public DbSet<urunler> urunler { get; set; }
    }
}
