using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjectWebApp.Models;

namespace ProjectWebApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Klant> Klanten { get; set; }
        public DbSet<Opleiding> Opleidingen { get; set; }
        public DbSet<Algemeenheden> Algemeenheden { get; set; }
        public DbSet<Categorie> Categorieen { get; set; }
        public DbSet<Federatie> Federaties { get; set; }
        public DbSet<Niveau> Niveaus { get; set; }
        public DbSet<Omschrijving> Omschrijvingen { get; set; }
        public DbSet<Slot> Slot { get; set; }
        public DbSet<Voorwaarden> Voorwaarden { get; set; }
    }
}
