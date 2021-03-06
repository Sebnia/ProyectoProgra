﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProyectoProgra.Models;

namespace ProyectoProgra.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        
        public DbSet<ProyectoProgra.Models.Contacto> Contactos { get; set; }

        public DbSet<Producto> Productos { get; set;}

        public DbSet<OrdenDetail> OrdenDetails { get; set; }

    }
}
