﻿// <auto-generated />
using System;
using GIDT.Datas;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GIDT.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20230430004236_MyFirstMigrations")]
    partial class MyFirstMigrations
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("GIDT.Models.Adresse", b =>
                {
                    b.Property<Guid>("AdresseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AdresseComplete")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cellulaire")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CodePostal")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pays")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telephone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UtilisateurId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ville")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AdresseId");

                    b.HasIndex("UtilisateurId");

                    b.ToTable("Adresses");
                });

            modelBuilder.Entity("GIDT.Models.Image", b =>
                {
                    b.Property<Guid>("ImageID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("EstPrincipal")
                        .HasColumnType("bit");

                    b.Property<bool>("EstProfil")
                        .HasColumnType("bit");

                    b.Property<Guid>("UtilisateurId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte[]>("imageBlob")
                        .IsRequired()
                        .HasColumnType("varbinary(MAX)");

                    b.HasKey("ImageID");

                    b.HasIndex("UtilisateurId");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("GIDT.Models.Message", b =>
                {
                    b.Property<int>("MessageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MessageId"), 1L, 1);

                    b.Property<string>("Contenu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateDeCreation")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateDeModification")
                        .HasColumnType("datetime2");

                    b.Property<bool>("EstLu")
                        .HasColumnType("bit");

                    b.Property<Guid>("UtilisateurId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("MessageId");

                    b.HasIndex("UtilisateurId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("GIDT.Models.Utilisateur", b =>
                {
                    b.Property<Guid>("UtilisateurId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateDeCreation")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateDeModification")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateDeNaissance")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateDerniereConnexion")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MotdePass")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pseudo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UtilisateurId");

                    b.ToTable("Utilisateurs");
                });

            modelBuilder.Entity("GIDT.Models.Adresse", b =>
                {
                    b.HasOne("GIDT.Models.Utilisateur", "Utilisateur")
                        .WithMany("Adresses")
                        .HasForeignKey("UtilisateurId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Utilisateur");
                });

            modelBuilder.Entity("GIDT.Models.Image", b =>
                {
                    b.HasOne("GIDT.Models.Utilisateur", "Utilisateur")
                        .WithMany("Images")
                        .HasForeignKey("UtilisateurId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Utilisateur");
                });

            modelBuilder.Entity("GIDT.Models.Message", b =>
                {
                    b.HasOne("GIDT.Models.Utilisateur", "Utilisateur")
                        .WithMany("Messages")
                        .HasForeignKey("UtilisateurId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Utilisateur");
                });

            modelBuilder.Entity("GIDT.Models.Utilisateur", b =>
                {
                    b.Navigation("Adresses");

                    b.Navigation("Images");

                    b.Navigation("Messages");
                });
#pragma warning restore 612, 618
        }
    }
}
