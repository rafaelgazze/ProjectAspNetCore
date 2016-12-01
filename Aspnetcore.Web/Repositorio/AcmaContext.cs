using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aspnetcore.Web.Model;
using Microsoft.EntityFrameworkCore;

namespace Aspnetcore.Web.Context
{
    public class AcmeContext : DbContext
    {
        public AcmeContext(DbContextOptions<AcmeContext> options) : base(options)
        {
            this.Database.EnsureCreated();
        }
        
        public  DbSet<MateriaPrima> MateriasPrimas { get; set; }
        public  DbSet<Produto> Produtos { get; set; }
        public DbSet<Producao> Producao { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MateriaPrima>().ToTable("MateriaPrima");
            modelBuilder.Entity<Produto>().ToTable("Produto");
            modelBuilder.Entity<Producao>().ToTable("Producao");
        }
    }
}
