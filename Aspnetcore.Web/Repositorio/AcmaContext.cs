using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aspnetcore.Web.Model;
using Microsoft.EntityFrameworkCore;

namespace Aspnetcore.Web.Context
{
    public class AcmaContext : DbContext
    {
        public AcmaContext(DbContextOptions<AcmaContext> options) : base(options)
        {
            this.Database.EnsureCreated();
        }
        
        private DbSet<MateriaPrima> MateriasPrimas { get; set; }
        private DbSet<Produto> Produtos { get; set; }
    }
}
