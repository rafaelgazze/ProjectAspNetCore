using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Aspnetcore.Web.Context;

namespace Aspnetcore.web.Migrations
{
    [DbContext(typeof(AcmeContext))]
    [Migration("20161114190552_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Aspnetcore.Web.Model.MateriaPrima", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("EstoqueMaximo");

                    b.Property<int>("EstoqueMinimo");

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("MateriasPrimas");
                });

            modelBuilder.Entity("Aspnetcore.Web.Model.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("Produtos");
                });
        }
    }
}
