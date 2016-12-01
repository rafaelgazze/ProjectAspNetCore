using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Aspnetcore.Web.Context;

namespace Aspnetcore.web.Migrations
{
    [DbContext(typeof(AcmeContext))]
    [Migration("20161114192317_SecondCreate")]
    partial class SecondCreate
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

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 150);

                    b.HasKey("Id");

                    b.ToTable("MateriaPrima");
                });

            modelBuilder.Entity("Aspnetcore.Web.Model.Producao", b =>
                {
                    b.Property<int>("ProducaoId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("MateriaPrimaId");

                    b.Property<int>("ProdutoId");

                    b.Property<int>("Quantidade");

                    b.HasKey("ProducaoId");

                    b.HasIndex("MateriaPrimaId");

                    b.HasIndex("ProdutoId");

                    b.ToTable("Producao");
                });

            modelBuilder.Entity("Aspnetcore.Web.Model.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 150);

                    b.HasKey("Id");

                    b.ToTable("Produto");
                });

            modelBuilder.Entity("Aspnetcore.Web.Model.Producao", b =>
                {
                    b.HasOne("Aspnetcore.Web.Model.MateriaPrima", "MateriaPrima")
                        .WithMany()
                        .HasForeignKey("MateriaPrimaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Aspnetcore.Web.Model.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
