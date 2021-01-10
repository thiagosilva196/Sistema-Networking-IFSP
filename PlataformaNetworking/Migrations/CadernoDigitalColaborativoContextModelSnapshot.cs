﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PlataformaNetworking.Data;

namespace PlataformaNetworking.Migrations
{
    [DbContext(typeof(PlataformaNetworkingContext))]
    partial class CadernoDigitalColaborativoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PlataformaNetworking.Models.Amizade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdUsuario1");

                    b.Property<int>("IdUsuario2");

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.ToTable("Amizade");
                });

            modelBuilder.Entity("PlataformaNetworking.Models.Candidato", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<int>("IdUsuario");

                    b.Property<int>("IdVaga");

                    b.Property<string>("Nome");

                    b.Property<string>("Sobrenome");

                    b.HasKey("Id");

                    b.ToTable("Candidato");
                });

            modelBuilder.Entity("PlataformaNetworking.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CommentText");

                    b.Property<DateTime>("CommentTime");

                    b.Property<int>("IdPost");

                    b.Property<int>("IdUsuario");

                    b.Property<int?>("PostModelId");

                    b.HasKey("Id");

                    b.HasIndex("PostModelId");

                    b.ToTable("Comment");
                });

            modelBuilder.Entity("PlataformaNetworking.Models.Curriculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte[]>("Dados");

                    b.Property<string>("Nome");

                    b.Property<string>("Tipo");

                    b.HasKey("Id");

                    b.ToTable("Curriculo");
                });

            modelBuilder.Entity("PlataformaNetworking.Models.DislikeModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTimeOffset>("DislikedAt");

                    b.Property<int>("IdUsuario1");

                    b.Property<int>("IdUsuario2");

                    b.Property<int?>("Usario1Id");

                    b.Property<int?>("Usario2Id");

                    b.HasKey("Id");

                    b.HasIndex("Usario1Id");

                    b.HasIndex("Usario2Id");

                    b.ToTable("Dislike");
                });

            modelBuilder.Entity("PlataformaNetworking.Models.Habilidade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdAluno");

                    b.Property<string>("NomeHabilidade");

                    b.Property<int>("Recomendacoes");

                    b.HasKey("Id");

                    b.ToTable("Habilidade");
                });

            modelBuilder.Entity("PlataformaNetworking.Models.HabilidadeVaga", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdVaga");

                    b.Property<string>("NomeHabilidade");

                    b.HasKey("Id");

                    b.ToTable("HabilidadeVaga");
                });

            modelBuilder.Entity("PlataformaNetworking.Models.LikeModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdPost");

                    b.Property<int>("IdUsuario");

                    b.HasKey("Id");

                    b.ToTable("Like");
                });

            modelBuilder.Entity("PlataformaNetworking.Models.PostModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Comentarios");

                    b.Property<int>("Compartilhamentos");

                    b.Property<string>("FotoUsuario");

                    b.Property<int>("IdUsuario");

                    b.Property<string>("Imagem");

                    b.Property<int>("Like");

                    b.Property<string>("NomeUsuario");

                    b.Property<DateTime>("PostTime");

                    b.Property<string>("TextoPost");

                    b.Property<int?>("UsuarioPostId");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioPostId");

                    b.ToTable("Post");
                });

            modelBuilder.Entity("PlataformaNetworking.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amizades");

                    b.Property<bool>("AmizadesPendentes");

                    b.Property<string>("Curso");

                    b.Property<DateTime>("DataNascimento");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Email");

                    b.Property<string>("Nome");

                    b.Property<string>("ProfilePictureUrl");

                    b.Property<string>("Senha");

                    b.Property<int>("Situacao");

                    b.Property<string>("Sobrenome");

                    b.HasKey("Id");

                    b.ToTable("Usuario");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Usuario");
                });

            modelBuilder.Entity("PlataformaNetworking.Models.Vaga", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Conteudo");

                    b.Property<DateTime>("DataPostagem");

                    b.Property<int>("IdUsuario");

                    b.Property<string>("Titulo");

                    b.HasKey("Id");

                    b.ToTable("Vaga");
                });

            modelBuilder.Entity("PlataformaNetworking.Models.Administrador", b =>
                {
                    b.HasBaseType("PlataformaNetworking.Models.Usuario");


                    b.ToTable("Administrador");

                    b.HasDiscriminator().HasValue("Administrador");
                });

            modelBuilder.Entity("PlataformaNetworking.Models.Aluno", b =>
                {
                    b.HasBaseType("PlataformaNetworking.Models.Usuario");

                    b.Property<int>("AnoIngresso");

                    b.Property<int?>("CurriculoId");

                    b.Property<string>("Habilidades");

                    b.HasIndex("CurriculoId");

                    b.ToTable("Aluno");

                    b.HasDiscriminator().HasValue("Aluno");
                });

            modelBuilder.Entity("PlataformaNetworking.Models.Empresa", b =>
                {
                    b.HasBaseType("PlataformaNetworking.Models.Usuario");

                    b.Property<string>("CNPJ");

                    b.Property<string>("Ramo");

                    b.Property<string>("RazaoSocial");

                    b.ToTable("Empresa");

                    b.HasDiscriminator().HasValue("Empresa");
                });

            modelBuilder.Entity("PlataformaNetworking.Models.Professor", b =>
                {
                    b.HasBaseType("PlataformaNetworking.Models.Usuario");

                    b.Property<string>("Especialidades");

                    b.ToTable("Professor");

                    b.HasDiscriminator().HasValue("Professor");
                });

            modelBuilder.Entity("PlataformaNetworking.Models.Comment", b =>
                {
                    b.HasOne("PlataformaNetworking.Models.PostModel")
                        .WithMany("Comments")
                        .HasForeignKey("PostModelId");
                });

            modelBuilder.Entity("PlataformaNetworking.Models.DislikeModel", b =>
                {
                    b.HasOne("PlataformaNetworking.Models.Usuario", "Usario1")
                        .WithMany()
                        .HasForeignKey("Usario1Id");

                    b.HasOne("PlataformaNetworking.Models.Usuario", "Usario2")
                        .WithMany()
                        .HasForeignKey("Usario2Id");
                });

            modelBuilder.Entity("PlataformaNetworking.Models.PostModel", b =>
                {
                    b.HasOne("PlataformaNetworking.Models.Usuario", "UsuarioPost")
                        .WithMany()
                        .HasForeignKey("UsuarioPostId");
                });

            modelBuilder.Entity("PlataformaNetworking.Models.Aluno", b =>
                {
                    b.HasOne("PlataformaNetworking.Models.Curriculo", "Curriculo")
                        .WithMany()
                        .HasForeignKey("CurriculoId");
                });
#pragma warning restore 612, 618
        }
    }
}
