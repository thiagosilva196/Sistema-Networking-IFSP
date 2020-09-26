﻿// <auto-generated />

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using PlataformaNetworking.Data;

namespace PlataformaNetworking.Migrations
{
    [DbContext(typeof(PlataformaNetworkingContext))]
    [Migration("20200821032126_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CadernoDigitalColaborativo.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AnoIngresso");

                    b.Property<string>("Curso");

                    b.Property<int>("CursoId");

                    b.Property<DateTime>("DataNascimento");

                    b.Property<string>("Email");

                    b.Property<string>("Nome");

                    b.Property<string>("ProfilePictureUrl");

                    b.Property<int>("Semestre");

                    b.Property<string>("Senha");

                    b.Property<int>("Situacao");

                    b.Property<string>("Sobrenome");

                    b.HasKey("Id");

                    b.ToTable("Usuario");
                });
#pragma warning restore 612, 618
        }
    }
}
