﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Yogurt.Infraestructure.Context;

#nullable disable

namespace Yogurt.Infraestructure.Migrations
{
    [DbContext(typeof(YogurtContext))]
    [Migration("20220619233109_final")]
    partial class final
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Yogurt.Domain.Entities.CityEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IdEstado")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("IdEstado");

                    b.ToTable("Cidade");
                });

            modelBuilder.Entity("Yogurt.Domain.Entities.Comment.CommentEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<int>("Curtidas")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("IdCompartilhamento")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("IdPublicacao")
                        .HasColumnType("char(36)");

                    b.Property<string>("Legenda")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Comentarios");
                });

            modelBuilder.Entity("Yogurt.Domain.Entities.ComunidadeEntity.CommunityEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime(6)");

                    b.Property<byte[]>("FotoComunidade")
                        .IsRequired()
                        .HasColumnType("longblob");

                    b.Property<Guid>("IdCategoriaComunidade")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("IdCriador")
                        .HasColumnType("char(36)");

                    b.Property<string>("Legenda")
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Comunidade");
                });

            modelBuilder.Entity("Yogurt.Domain.Entities.ConnectEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("IdAmizade")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("IdPerfil")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("IdAmizade");

                    b.HasIndex("IdPerfil");

                    b.ToTable("Conectar");
                });

            modelBuilder.Entity("Yogurt.Domain.Entities.ConnectivityEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("IdComunidade")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("IdPerfil")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("IdComunidade");

                    b.HasIndex("IdPerfil");

                    b.ToTable("Conectividade");
                });

            modelBuilder.Entity("Yogurt.Domain.Entities.FileEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<byte[]>("Conteudo")
                        .IsRequired()
                        .HasColumnType("longblob");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("IdPublicacao")
                        .HasColumnType("char(36)");

                    b.Property<string>("MimeType")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("IdPublicacao");

                    b.ToTable("Arquivos");
                });

            modelBuilder.Entity("Yogurt.Domain.Entities.FriendEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("IdPerfil")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("IdPerfil");

                    b.ToTable("Amizade");
                });

            modelBuilder.Entity("Yogurt.Domain.Entities.ProfileUserEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Biografia")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DataNascimento")
                        .HasColumnType("datetime(6)");

                    b.Property<byte[]>("FotoPerfil")
                        .HasColumnType("longblob");

                    b.Property<string>("Genero")
                        .HasColumnType("longtext");

                    b.Property<int>("IdCidade")
                        .HasColumnType("int");

                    b.Property<Guid>("IdUsuario")
                        .HasColumnType("char(36)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("IdCidade");

                    b.HasIndex("IdUsuario")
                        .IsUnique();

                    b.ToTable("Perfil");
                });

            modelBuilder.Entity("Yogurt.Domain.Entities.Publication.PublicacaoEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<int>("Curtidas")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid?>("IdComunidade")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("IdPerfil")
                        .HasColumnType("char(36)");

                    b.Property<string>("Legenda")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("IdComunidade");

                    b.HasIndex("IdPerfil");

                    b.ToTable("Publicacao");
                });

            modelBuilder.Entity("Yogurt.Domain.Entities.ReplyComment.ReplyCommentEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("IdComentario")
                        .HasColumnType("char(36)");

                    b.Property<string>("Legenda")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Resposta");
                });

            modelBuilder.Entity("Yogurt.Domain.Entities.StatesEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Sigla")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Estado");
                });

            modelBuilder.Entity("Yogurt.Domain.Entities.User.UserEntity", b =>
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

            modelBuilder.Entity("Yogurt.Domain.Entities.CityEntity", b =>
                {
                    b.HasOne("Yogurt.Domain.Entities.StatesEntity", "Estado")
                        .WithMany("Cidades")
                        .HasForeignKey("IdEstado")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Estado");
                });

            modelBuilder.Entity("Yogurt.Domain.Entities.ConnectEntity", b =>
                {
                    b.HasOne("Yogurt.Domain.Entities.FriendEntity", "Amizade")
                        .WithMany("Connects")
                        .HasForeignKey("IdAmizade")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Yogurt.Domain.Entities.ProfileUserEntity", "Perfil")
                        .WithMany("Connects")
                        .HasForeignKey("IdPerfil")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Amizade");

                    b.Navigation("Perfil");
                });

            modelBuilder.Entity("Yogurt.Domain.Entities.ConnectivityEntity", b =>
                {
                    b.HasOne("Yogurt.Domain.Entities.ComunidadeEntity.CommunityEntity", "Comunidade")
                        .WithMany("Conectividades")
                        .HasForeignKey("IdComunidade")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Yogurt.Domain.Entities.ProfileUserEntity", "Perfil")
                        .WithMany("Conectividades")
                        .HasForeignKey("IdPerfil")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Comunidade");

                    b.Navigation("Perfil");
                });

            modelBuilder.Entity("Yogurt.Domain.Entities.FileEntity", b =>
                {
                    b.HasOne("Yogurt.Domain.Entities.Publication.PublicacaoEntity", "publicacao")
                        .WithMany("FileEntities")
                        .HasForeignKey("IdPublicacao")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("publicacao");
                });

            modelBuilder.Entity("Yogurt.Domain.Entities.FriendEntity", b =>
                {
                    b.HasOne("Yogurt.Domain.Entities.ProfileUserEntity", "Perfil")
                        .WithMany("Amigos")
                        .HasForeignKey("IdPerfil")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Perfil");
                });

            modelBuilder.Entity("Yogurt.Domain.Entities.ProfileUserEntity", b =>
                {
                    b.HasOne("Yogurt.Domain.Entities.CityEntity", "Cidade")
                        .WithMany("Perfis")
                        .HasForeignKey("IdCidade")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Yogurt.Domain.Entities.User.UserEntity", "Usuario")
                        .WithOne("Perfil")
                        .HasForeignKey("Yogurt.Domain.Entities.ProfileUserEntity", "IdUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cidade");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Yogurt.Domain.Entities.Publication.PublicacaoEntity", b =>
                {
                    b.HasOne("Yogurt.Domain.Entities.ComunidadeEntity.CommunityEntity", "Comunidade")
                        .WithMany("Publicacoes")
                        .HasForeignKey("IdComunidade");

                    b.HasOne("Yogurt.Domain.Entities.ProfileUserEntity", "Perfil")
                        .WithMany("Publicacoes")
                        .HasForeignKey("IdPerfil")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Comunidade");

                    b.Navigation("Perfil");
                });

            modelBuilder.Entity("Yogurt.Domain.Entities.CityEntity", b =>
                {
                    b.Navigation("Perfis");
                });

            modelBuilder.Entity("Yogurt.Domain.Entities.ComunidadeEntity.CommunityEntity", b =>
                {
                    b.Navigation("Conectividades");

                    b.Navigation("Publicacoes");
                });

            modelBuilder.Entity("Yogurt.Domain.Entities.FriendEntity", b =>
                {
                    b.Navigation("Connects");
                });

            modelBuilder.Entity("Yogurt.Domain.Entities.ProfileUserEntity", b =>
                {
                    b.Navigation("Amigos");

                    b.Navigation("Conectividades");

                    b.Navigation("Connects");

                    b.Navigation("Publicacoes");
                });

            modelBuilder.Entity("Yogurt.Domain.Entities.Publication.PublicacaoEntity", b =>
                {
                    b.Navigation("FileEntities");
                });

            modelBuilder.Entity("Yogurt.Domain.Entities.StatesEntity", b =>
                {
                    b.Navigation("Cidades");
                });

            modelBuilder.Entity("Yogurt.Domain.Entities.User.UserEntity", b =>
                {
                    b.Navigation("Perfil")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
