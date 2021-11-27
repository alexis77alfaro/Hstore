using HardwareStore.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HardwareStore.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Usuario> usuario { get; set; }

        public DbSet<Producto> producto { get; set; }

        public DbSet<Venta> venta { get; set; }

        public DbSet<DetalleVenta> detalleVenta { get; set; }
    }
}
