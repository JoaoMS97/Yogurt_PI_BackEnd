﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Yogurt.Infraestructure.Context;

#nullable disable

namespace Yogurt.Infraestructure.Migrations
{
    [DbContext(typeof(YogurtContext))]
    partial class YogurtContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Yogurt.Domain.Entities.CommentEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<int>("Curtidas")
                        .HasColumnType("int");

                    b.Property<DateTime>("Data_Criacao")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("Id_Compartilhamento")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("Id_Publicacao")
                        .HasColumnType("char(36)");

                    b.Property<string>("Legenda")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Comentarios");
                });

            modelBuilder.Entity("Yogurt.Domain.Entities.PublicacaoEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<int>("Curtidas")
                        .HasColumnType("int");

                    b.Property<DateTime>("Data_Criacao")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid?>("Id_Comunidade")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("Id_Perfil")
                        .HasColumnType("char(36)");

                    b.Property<string>("Legenda")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Publicacao");
                });

            modelBuilder.Entity("Yogurt.Domain.Entities.ReplyCommentEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("Data_Criacao")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("Id_Comentarios")
                        .HasColumnType("char(36)");

                    b.Property<string>("Legenda")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Resposta");
                });

            modelBuilder.Entity("Yogurt.Domain.Entities.UserEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .HasColumnType("longtext");

                    b.Property<string>("Telefone")
                        .HasColumnType("longtext");

                    b.Property<string>("Token")
                        .HasColumnType("longtext");

                    b.Property<string>("UserName")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Usuario");
                });
#pragma warning restore 612, 618
        }
    }
}
