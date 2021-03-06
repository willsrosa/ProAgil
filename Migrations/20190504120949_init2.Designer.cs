﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjetoAgil.WebAPI.Data;

namespace ProjetoAgil.WebAPI.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20190504120949_init2")]
    partial class init2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085");

            modelBuilder.Entity("ProjetoAgil.WebAPI.Model.Evento", b =>
                {
                    b.Property<int>("EventoId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DataEvento");

                    b.Property<string>("Local");

                    b.Property<string>("Lote");

                    b.Property<int>("QtdePessoas");

                    b.Property<string>("Tema");

                    b.HasKey("EventoId");

                    b.ToTable("Evento");
                });
#pragma warning restore 612, 618
        }
    }
}
